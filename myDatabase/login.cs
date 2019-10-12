using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace ShpApp.myDatabase
{
    public class login
    {
        [PrimaryKey, AutoIncrement]
        public int it { get; set; }
        [MaxLength(250)]
        public string email { get; set; }
        [MaxLength(250)]
        public string password { get; set; }

    }
}
