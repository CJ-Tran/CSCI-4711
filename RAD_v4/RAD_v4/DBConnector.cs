using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using System.Data.SQLite;
using System.Security.Cryptography;

namespace Controller
{
    static class DBConnector
    {
        
        private static SQLiteConnection conn = new SQLiteConnection("Data Source=KMTS.db;Version=3;");
        private static SQLiteCommand cmd;
        public static void Initialize()
        {
            try
            {
                //SQLiteConnection conn = new SQLiteConnection("Data Source=PasswordManager.s3db;Version=3;");
                //SQLiteCommand cmd = conn.CreateCommand();// cmd is associated with the connector

                //start DB
                conn.Open();
                cmd = conn.CreateCommand();

                //User
                cmd.CommandText = "" +
                    "CREATE TABLE IF NOT EXISTS User (" +
                    "UName TEXT NOT NULL," +
                    "PwdHash TEXT NOT NULL," +
                    "Type INTEGER NOT NULL," +
                    "PRIMARY KEY (UName));";
                cmd.ExecuteNonQuery();

                //Key
                cmd.CommandText = "" +
                    "CREATE TABLE IF NOT EXISTS Key (" +
                    "Id INTEGER NOT NULL," +
                    "CurrentAssigned TEXT NULL," +
                    "LastAssigned TEXT NULL," +
                    "RoomNum INTEGER NOT NULL," +
                    "Status INT NOT NULL," +
                    "PRIMARY KEY (Id));";
                cmd.ExecuteNonQuery();

                //AccessEvent
                cmd.CommandText = "" +
                    "CREATE TABLE IF NOT EXISTS AccessEvent (" +
                    "User TEXT NOT NULL," +
                    "Time NUMERIC NOT NULL," +
                    "Type TEXT NOT NULL," +
                    "PRIMARY KEY (User, Time));";
                cmd.ExecuteNonQuery();

                //AddUser("ecustomer", "custPass", User.AcctType.Customer);
                //AddUser("eadmin", "adminPass", User.AcctType.Admin);
            }//try
            catch (Exception e)
            {
                conn.Close();
                throw new SQLiteException("An error occurred while attempting to initialize the database. Source of error: " + e.Source);
            }//catch
        }//Initialize()
		
        public static User GetUser(string uName, out string storedHash)
        {
            try
            {
                cmd = new SQLiteCommand("SELECT PwdHash,Type FROM User WHERE UName = @textValue1", conn);
                cmd.Parameters.AddWithValue("@textValue1", uName);
                /*
                cmd = conn.CreateCommand();
                cmd.CommandText = "" +
                    "SELECT PwdHash FROM User" +
                    $"WHERE UName = {uName};";
                */
                SQLiteDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    storedHash = reader.GetString(0);
                    return new User(uName, (User.AcctType)reader.GetInt32(1));
                }
                else
                {
                    throw new UnauthorizedAccessException("Something went wrong while retrieving user from db");
                }
                //putting this link for when we begin implementing the hashing algorithm
                //https://stackoverflow.com/questions/4181198/how-to-hash-a-password#10402129
            }//try
            catch (Exception)
            {
                throw new Exception("GetUser() threw an exception (Probably bad user)"); //Probably gonna throw this exception when username/password is incorrect
            }//catch
        }//GetUser()

        public static KeyList GetKeys()
        {
            List<Key> kList = new List<Key>(); //populate klist with query of keys before returning
            try
            {
                cmd = new SQLiteCommand("SELECT * from key", conn);
                SQLiteDataReader reader = cmd.ExecuteReader();
                Key k;
                while (reader.Read())
                {
                    int id = reader.GetInt32(0);
                    string currentAssigned = reader.GetString(1);
                    string lastAssigned = reader.GetString(2);
                    int roomNum = reader.GetInt32(3);
                    StatusType status = (StatusType)reader.GetInt32(4);
                    k = new Key(id, status, roomNum, currentAssigned, lastAssigned);
                    kList.Add(k);
                }//while
            }//try
            catch (Exception e)
            {
                throw e;
                throw new SQLiteException("Failed to get KeyList");
            }
            return new KeyList(kList);
        }//GetKeys()

        //Updates a key's status via reservation
        public static bool Save(Reservation res)
        {
            try
            {
                cmd = conn.CreateCommand();
                cmd.CommandText = "" +
                    "UPDATE Key" +
                    $"Set Status = {(int)StatusType.Pending}" +
                    $"WHERE Id = {res.KeyID};";
                cmd.ExecuteNonQuery();

                //Get current user and set it to previousUser
                cmd.CommandText = "" +
                    "SELECT CurrentAssigned FROM Key" +
                    $"Where Id = {res.KeyID};";
                SQLiteDataReader reader = cmd.ExecuteReader();
                string nowPrevUser = string.Empty;
                if (reader.Read())
                    nowPrevUser = reader.GetString(0);
                cmd.CommandText = "" +
                    "UPDATE Key" +
                    $"Set LastAssigned = {nowPrevUser}" +
                    $"WHERE Id = {res.KeyID};";
                cmd.ExecuteNonQuery();

                //Assign new user to CurrentUser
                cmd.CommandText = "" +
                    "UPDATE Key" +
                    $"Set CurrentAssigned = {res.UName}" +
                    $"WHERE ID = {res.KeyID};";
                cmd.ExecuteNonQuery();

                return true;
            }//try

            catch (Exception)
            {
                return false;
            }//catch
        }//Save(reservation)

        /* KeyStatus Getter */
        public static KeyStatus GetStatus(int key)
        {
            int status = -1;
            try
            {
                cmd = new SQLiteCommand("SELECT Status from Key where keyID = @textValue1", conn);
                cmd.Parameters.AddWithValue("@textValue1", key);
                SQLiteDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                    status = reader.GetInt32(0);
            }//try
            catch (Exception)
            {
                throw new SQLiteException($"Something went wrong while attempting to get status for key {key}");
            }//catch
            switch (status)
            {
                case (int)StatusType.Assigned:
                    return new KeyStatus(key, StatusType.Assigned);
                case (int)StatusType.Pending:
                    return new KeyStatus(key, StatusType.Pending);
                case (int)StatusType.Available:
                    return new KeyStatus(key, StatusType.Available);
                default:
                    throw new Exception($"Something went wrong while attempting to get status for key {key}");
            }//switch
        }//GetStatus()

        // Updates Key's Status
        public static void Save(KeyStatus keyStat)
        {
            try
            {
                cmd = new SQLiteCommand("UPDATE Key SET Status = @textValue1 WHERE Id = @textValue2", conn);
                cmd.Parameters.AddWithValue("@textValue1", (int)keyStat.Status);
                cmd.Parameters.AddWithValue("@textValue2", keyStat.KeyID);
                /*
                cmd = conn.CreateCommand();
                cmd.CommandText = "" +
                    "UPDATE Keys" +
                    $"Set Status = {(int)keyStat.Status}" +
                    $"WHERE Id = {keyStat.KeyID};";
                */
                cmd.ExecuteNonQuery();
            }//try
            catch (Exception)
            {
                throw new SQLiteException($"Something went wrong while trying to update the status of key {keyStat.KeyID}");
            }//catch
        }//Save(keystatus)

        public static void SaveLogin(User user)
        {
            try
            {
                cmd = new SQLiteCommand("INSERT INTO AccessEvent (User, Time, Type) VALUES (@textValue1, @textValue2, @textValue3)", conn);
                cmd.Parameters.AddWithValue("@textValue1", user.GetName());
                cmd.Parameters.AddWithValue("@textValue2", DateTime.Now);
                throw new Exception($"{DateTime.Now}");//REMOVE THIS
                cmd.Parameters.AddWithValue("@textValue3", "Login");
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw e; //REMOVE THIS
                conn.Close(); //close connection if exception is thrown while saving logout information
            }//catch
        }//SaveLogin()

        public static void SaveLogout(string name)
        {
            try
            {
                cmd = new SQLiteCommand("INSERT INTO AccessEvent (User, Time, Type) VALUES (@textValue1, @textValue2, @textValue3)", conn);
                cmd.Parameters.AddWithValue("@textValue1", name);
                cmd.Parameters.AddWithValue("@textValue2", DateTime.Now);
                cmd.Parameters.AddWithValue("@textValue3","Logout");
                cmd.ExecuteNonQuery();
                conn.Close(); //after saving logout, we can close the connection 
            }//try
            catch(Exception)
            {
                conn.Close(); //close connection if exception is thrown while saving logout information
                throw new SQLiteException("Program encountered an error while attempting to save logout event");
            }//catch
        }//SaveLogout()
        private static void AddUser(string uName, string password, User.AcctType type)
        {
            try
            {
                //creating a salted hash of the password
                byte[] salt;
                new RNGCryptoServiceProvider().GetBytes(salt = new byte[16]);
                var pbkdf2 = new Rfc2898DeriveBytes(password, salt, 100000);
                byte[] hash = pbkdf2.GetBytes(20);
                byte[] hashBytes = new byte[36];
                Array.Copy(salt, 0, hashBytes, 0, 16);
                Array.Copy(hash, 0, hashBytes, 16, 20);
                string savedPasswordHash = Convert.ToBase64String(hashBytes);

                cmd = new SQLiteCommand("INSERT INTO User(UName, PwdHash, Type) VALUES (@textValue1, @textValue2, @textValue3)", conn);
                cmd.Parameters.AddWithValue("@textValue1", uName);
                cmd.Parameters.AddWithValue("@textValue2", savedPasswordHash);
                cmd.Parameters.AddWithValue("@textValue3", (int)type);
                cmd.ExecuteNonQuery();
            }
            catch(Exception e)
            {
                throw e;
                throw new Exception("Unable to add user, something went wrong");
            }
        }//AddUser
    }//DBConnector
}//Controller namespace
