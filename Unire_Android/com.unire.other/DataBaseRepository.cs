using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System.IO;
using System.Data;
using SQLite;

namespace Unire_Android.com.unire.other
{
    public class DataBaseRepository
    {
        // code create the db
        public string CreateDB()
        {
            var output = "";
            output += "Creating Db if not exist";
            string dbPath = Path.Combine(System.Environment.GetFolderPath
                (System.Environment.SpecialFolder.Personal), "ormdemo.db3");
            var db = new SQLiteConnection(dbPath);
            output += "\nDatabase Created...";
            return output;
        }
        // Create table

        public string CreateTable()
        {
            try
            {

                string dbPath = Path.Combine(System.Environment.GetFolderPath
                (System.Environment.SpecialFolder.Personal), "ormdemo.db3");
                var db = new SQLiteConnection(dbPath);
                db.CreateTable<ToDoTasks>();
                string result = "Table Created";
                return result;
            }
            catch (Exception e)
            {

                return "Error :" + e.Message;

            }
        }


        // code to insert a record
        public string InsertRecord(string task)
        {
            try
            {

                string dbPath = Path.Combine(System.Environment.GetFolderPath
                (System.Environment.SpecialFolder.Personal), "ormdemo.db3");
                var db = new SQLiteConnection(dbPath);

                ToDoTasks Item = new ToDoTasks();
                Item.Task = task;
                db.Insert(Item);
                return "record addedd";
            }
            catch (Exception e)
            {

                return "Error :" + e.Message;

            }
        }
        // code to retrieve all records 
        public string GettAllRecords()
        {
            string dbPath = Path.Combine(System.Environment.GetFolderPath
            (System.Environment.SpecialFolder.Personal), "ormdemo.db3");
            var db = new SQLiteConnection(dbPath);
            string output = "";
            output += "Retrieving notifications";
            var table = db.Table<ToDoTasks>();
            foreach (var item in table)
            {
                output += "\n" + item.Id + "-" + item.Task;
            }
            return output;
        }
    }
}