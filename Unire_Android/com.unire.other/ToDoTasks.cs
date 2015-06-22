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
    [Table("Notificaties")]
    public class ToDoTasks
    {

        [PrimaryKey, AutoIncrement, Column("id")]

        public int Id { get; set; }
        [MaxLength(50)]

        public string Task { get; set; }
    }
}