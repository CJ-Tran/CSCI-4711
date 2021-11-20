﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using System.Data.SQLite;

namespace Controller
{
    static class DBConnector
    {
        
        private static SQLiteConnection conn = new SQLiteConnection("Data Source=KMTS.db;Version=3;");
        public static void Initialize()
        {
            try
            {
                conn.Open();
                SQLiteCommand cmd = conn.CreateCommand();

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
            }
            catch (Exception e)
            {
                conn.Close();
                throw new SQLiteException("An error occurred while attempting to initialize the database. Source of error: " + e.Source);
            }
        }
        /*
        static SQLiteConnection conn = new SQLiteConnection("Data Source=PasswordManager.s3db;Version=3;");//woriking way of creating a connection
        //static readonly SQLiteCommand cmd = new SQLiteCommand();
        public static void Initialize()
        {
            try
            {
                //SQLiteConnection conn = new SQLiteConnection("Data Source=PasswordManager.s3db;Version=3;");
                SQLiteCommand cmd = conn.CreateCommand();// cmd is associated with the connector

                //start DB
                conn.Open();

                //We might not want to have a drop schema line since that will wipe the User table every time the DB is initialized
                // the 'typeof' for TYPE can be int for simplicity (since the enum occurs in local code)
                cmd.CommandText = "" +
                    "DROP TABLE IF EXISTS User; " +
                    "DROP TABLE IF EXISTS Keys; " +
                    "DROP TABLE IF EXISTS Log; ";
                cmd.ExecuteNonQuery();

                cmd.CommandText = "" +
                    "CREATE TABLE User (" +
                    "UName VARCHAR(50)," +
                    "PWord CHAR(16)," +
                    "TYPE SMALLINT," + // Customer = 0, Admin = 1
                    "PRIMARY KEY (UName, PWord)" +//MULTIPLE PRIMARY KEY SYNTAX
                    ")";
                cmd.ExecuteNonQuery();

                cmd.CommandText = "" +
                    "CREATE TABLE Keys (" +
                    "ID VARCHAR(16) PRIMARY KEY," +
                    "Status VARCHAR(10)," +
                    "CurrentUser VARCHAR(16)," +
                    "PreviousUser VARCHAR(16)," +
                    "RoomNum SMALLINT" +
                    ")";
                cmd.ExecuteNonQuery();

                cmd.CommandText = "" +
                    "CREATE TABLE Log (" +
                    "User VARCHAR(16) PRIMARY KEY," +
                    "Login DATETIME," +
                    "Logout DATETIME" +
                    ")";
                cmd.ExecuteNonQuery();

                // Was just trying to get it to display and see if it was working

                cmd.CommandText = "" +
                    "SELECT * FROM User;";
                cmd.ExecuteNonQuery();

                SQLiteDataReader reader;
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string myreader = reader.GetString(0);
                    Console.WriteLine(myreader);
                }
                
                conn.Close();
            }
            catch (Exception)
            {
                throw new Exception("Error at DBConnector.Initialize()");
            }
        }
        */
        public static User GetUser(string uName, string pwdHash)
        {
            try
            {
                return new User(uName);
                //putting this link for when we begin implementing the hashing algorithm
                //https://stackoverflow.com/questions/4181198/how-to-hash-a-password#10402129
            }
            catch (Exception)
            {
                throw new Exception("GetUser() threw an exception"); //Probably gonna throw this exception when username/password is incorrect
            }
        }

        public static KeyList GetKeys()
        {
            List<Key> kList = new List<Key>(); //keys from database should be placed into this list
            return new KeyList(kList);
        }

        //Updates a key's status via reservation
        public static bool Save(Reservation res)
        {
            try
            {
                SQLiteCommand cmd = new SQLiteCommand();
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
                SQLiteCommand cmd = new SQLiteCommand();
                cmd.CommandText = "" +
                    "SELECT Status" +
                    "FROM Keys" +
                    $"WHERE ID = {key};";

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
                SQLiteCommand cmd = new SQLiteCommand();
                cmd.CommandText = "" +
                    "UPDATE Keys" +
                    $"Set Status = {(int)keyStat.Status}" +
                    $"WHERE Id = {keyStat.KeyID};";
                cmd.ExecuteNonQuery();
            }//try
            catch (Exception)
            {
                throw new SQLiteException($"Something went wrong while trying to update the status of key {keyStat.KeyID}");
            }//catch
        }//Save(keystatus)

        public static void SaveLogout(string name)
        {
            try
            {
                SQLiteCommand cmd = new SQLiteCommand();
                cmd.CommandText = "" +
                    "INSERT INTO AccessEvent VALUES(" +
                    $"{name}," +
                    $"{DateTime.Now}," +
                    "Logout);";
                cmd.ExecuteNonQuery();
                conn.Close(); //after saving logout, we can close the connection 
            }//try
            catch(Exception)
            {
                conn.Close(); //close connection if exception is thrown while saving logout information
            }//catch
        }//SaveLogout()
    }//DBConnector
}//Controller namespace
