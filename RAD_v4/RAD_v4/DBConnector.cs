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
        private static SQLiteDataReader reader;
        public static void Initialize()
        {
            try
            {
                //SQLiteConnection conn = new SQLiteConnection("Data Source=PasswordManager.s3db;Version=3;");
                //SQLiteCommand cmd = conn.CreateCommand();// cmd is associated with the connector

                //start DB
                if (WaitForConnection())
                {
                    cmd = conn.CreateCommand();

                    cmd.CommandText = "" +
                        "PRAGMA foreign_keys = 1;";
                    cmd.ExecuteNonQuery();

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
                        "CurrentAssigned TEXT NULL REFERENCES User (UName) ON DELETE SET NULL ON UPDATE CASCADE," +
                        "LastAssigned TEXT NULL REFERENCES User(UName) ON DELETE SET NULL ON UPDATE CASCADE," +
                        "RoomNum INTEGER NOT NULL," +
                        "Status INT NOT NULL," +
                        "PRIMARY KEY (Id));";
                    cmd.ExecuteNonQuery();

                    //AccessEvent
                    cmd.CommandText = "" +
                        "CREATE TABLE IF NOT EXISTS AccessEvent (" +
                        "User TEXT NOT NULL REFERENCES User (UName) ON DELETE NO ACTION ON UPDATE CASCADE," +
                        "Time NUMERIC NOT NULL," +
                        "Type TEXT NOT NULL," +
                        "PRIMARY KEY (User, Time));";
                    cmd.ExecuteNonQuery();




                    /*
                     * The following is for initializing test data into the DB
                     * Please treat this portion of Initialize as though it exists outside the scope of the program
                     * thank you,
                     * Chris J.
                     */

                    //BEGIN TEST DATA ENTRY

                    cmd = new SQLiteCommand("SELECT UName FROM User", conn);
                    reader = cmd.ExecuteReader();
                    if (!reader.Read())//if no users in db, add test users
                    {
                        //purge all users from db if you want to add more (call this block again)
                        AddUserToDB("ecustomer", "custPass", User.AcctType.Customer);
                        AddUserToDB("eadmin", "adminPass", User.AcctType.Admin);
                    }//fi

                    cmd = new SQLiteCommand("SELECT Id FROM Key", conn);
                    reader = cmd.ExecuteReader();
                    if (!reader.Read())// if no keys in db, add test keys
                    {
                        //purge all keys from db if you want to add more (call this block again)
                        AddKeyToDB(0, 1);
                        AddKeyToDB(1, 2, (int)StatusType.Available, "eadmin");
                        AddKeyToDB(2, 3);
                    }//fi

                    //END OF TEST DATA ENTRY

                }//fi
                else
                    throw new Exception();
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
                if (WaitForConnection())
                {
                    cmd = new SQLiteCommand("SELECT PwdHash,Type FROM User WHERE UName = @textValue1", conn);
                    cmd.Parameters.AddWithValue("@textValue1", uName);
                    /*
                    cmd = conn.CreateCommand();
                    cmd.CommandText = "" +
                        "SELECT PwdHash FROM User" +
                        $"WHERE UName = {uName};";
                    */
                    reader = cmd.ExecuteReader();
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
                }
                else
                    throw new Exception("Could not get connection");
            }//try
            catch (Exception e)
            {
                throw new Exception("GetUser() threw an exception (Probably bad user)" + e.GetType()); //Probably gonna throw this exception when username/password is incorrect
            }//catch
        }//GetUser()

        public static KeyList GetKeys()
        {
            int id;
            string currentAssigned;
            string lastAssigned;
            int roomNum;
            StatusType status;
            List<Key> kList = new List<Key>(); //populate klist with query of keys before returning
            try
            {
                cmd = new SQLiteCommand("SELECT * from key", conn);
                reader = cmd.ExecuteReader();
                Key k;
                while (reader.Read())
                {
                    id = reader.GetInt32(0);
                    if (reader.IsDBNull(1))
                    {
                        currentAssigned = string.Empty;
                    }
                    else
                    {
                        currentAssigned = reader.GetString(1);
                    }
                    if (reader.IsDBNull(2))
                    {
                        lastAssigned = string.Empty;
                    }
                    else
                    {
                        lastAssigned = reader.GetString(2);
                    }
                    roomNum = reader.GetInt32(3);
                    status = (StatusType)reader.GetInt32(4);
                    k = new Key(id, status, roomNum, currentAssigned, lastAssigned);
                    kList.Add(k);
                }//while
            }//try
            catch (Exception)
            {
                throw new SQLiteException("Failed to get KeyList");
            }
            return new KeyList(kList);
        }//GetKeys()

        //Updates a key's status via reservation
        public static bool Save(Reservation res)
        {
            try
            {
                cmd = new SQLiteCommand("UPDATE Key SET Status = @tv1 WHERE Id = @tv2", conn);
                cmd.Parameters.AddWithValue("@tv1",(int)StatusType.Pending);
                cmd.Parameters.AddWithValue("@tv2", res.KeyID);
                cmd.ExecuteNonQuery();

                //Get current user and set it to previousUser
                cmd = new SQLiteCommand("SELECT CurrentAssigned FROM Key WHERE Id = @tv1", conn);
                cmd.Parameters.AddWithValue("@tv1", res.KeyID);
                reader = cmd.ExecuteReader();
                string nowPrevUser = string.Empty;
                if (reader.Read())
                    if (!reader.IsDBNull(0))
                    {
                        nowPrevUser = reader.GetString(0);
                        cmd = new SQLiteCommand("UPDATE Key SET LastAssigned = @tv1 WHERE Id = @tv2", conn);
                        cmd.Parameters.AddWithValue("@tv1", nowPrevUser);
                        cmd.Parameters.AddWithValue("@tv2", res.KeyID);
                        cmd.ExecuteNonQuery();
                    }
                //Assign new user to CurrentUser
                cmd = new SQLiteCommand("UPDATE Key SET CurrentAssigned = @tv1 WHERE Id = @tv2", conn);
                cmd.Parameters.AddWithValue("@tv1", res.UName);
                cmd.Parameters.AddWithValue("@tv2", res.KeyID);
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
                reader = cmd.ExecuteReader();
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
                if (WaitForConnection())
                {
                    cmd = new SQLiteCommand("INSERT INTO AccessEvent (User, Time, Type) VALUES (@textValue1, @textValue2, @textValue3)", conn);
                    cmd.Parameters.AddWithValue("@textValue1", user.UName);
                    cmd.Parameters.AddWithValue("@textValue2", DateTime.UtcNow);
                    cmd.Parameters.AddWithValue("@textValue3", "Login");
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {
                conn.Close(); //close connection if exception is thrown while saving login information
                throw new Exception("Something went wrong while attempting to save login for " + user.UName + " at time " + DateTime.UtcNow);
            }//catch
        }//SaveLogin()

        public static void SaveLogout(string name)
        {
            try
            {
                cmd = new SQLiteCommand("INSERT INTO AccessEvent (User, Time, Type) VALUES (@textValue1, @textValue2, @textValue3)", conn);
                cmd.Parameters.AddWithValue("@textValue1", name);
                cmd.Parameters.AddWithValue("@textValue2", DateTime.UtcNow);
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

        private static bool WaitForConnection()
        {
            if (!conn.State.Equals(System.Data.ConnectionState.Open))
            {
                conn.Open();
                int waitCount = 0;
                while (conn.State.Equals(System.Data.ConnectionState.Closed))
                {
                    System.Threading.Thread.Sleep(100);
                    waitCount++;
                    if (waitCount > 999)
                        return false;
                    else
                        conn.Open();
                }//while
                return true;
            }//fi
            else
                return true;
        }//WaitForConnection()
        
        
        
        /*
         * These are not real, production methods.
         * They exists to add our test cases and are called only during initialization if the database has not yet been initialized with data
         * I kindly request that these be ignored during code review and treated as though they exist outside of the scope of this program
         * Thank you,
         * Chris J.
        */

        //BEGIN METHODS FOR ENTRY OF TESTING DATA

        private static void AddKeyToDB(int kNum, int roomNum, int status = (int)StatusType.Available, string currentUser = "", string previousUser = "")
        {
            try
            {
                if (currentUser.Equals(""))
                if (previousUser.Equals(""))
                    previousUser = string.Empty;
                cmd = new SQLiteCommand("INSERT INTO Key(Id,CurrentAssigned,LastAssigned,RoomNum,Status) VALUES (@tv1, @tv2, @tv3, @tv4, @tv5)", conn);
                cmd.Parameters.AddWithValue("@tv1", kNum);
                if (string.IsNullOrEmpty(currentUser))
                {
                    cmd.Parameters.AddWithValue("@tv2", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@tv2", currentUser);
                }
                if (string.IsNullOrEmpty(previousUser))
                {
                    cmd.Parameters.AddWithValue("@tv3", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@tv3", previousUser);
                }
                cmd.Parameters.AddWithValue("@tv4", roomNum);
                cmd.Parameters.AddWithValue("@tv5", status);
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw new Exception("Unable to add key, something went wrong!");
            }
        }//AddKeyToDB()
        private static void AddUserToDB(string uName, string password, User.AcctType type)
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
            catch(Exception)
            {
                throw new Exception("Unable to add user, something went wrong!");
            }
        }//AddUserToDB()

        //END METHODS FOR ENTRY OF TEST DATA

    }//DBConnector
}//Controller namespace
