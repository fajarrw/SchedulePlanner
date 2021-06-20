using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using SQLite;
using SchedulePlanner3.Model;

namespace SchedulePlanner3
{
    class DatabaseConnection
    {
        SQLiteConnection conn;
        DatabaseConnection (string dbPath)
        {
            conn = new SQLiteConnection(dbPath);
            conn.CreateTable<Member>();
            conn.CreateTable<Event>();
        }
    }
}
