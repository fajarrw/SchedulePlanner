using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using SchedulePlanner3.Model;

namespace SchedulePlanner3.Repository
{
    public class EventRepository
    {
        SQLiteConnection conn;
        public EventRepository(string dbPath)
        {
            conn = new SQLiteConnection(dbPath);
            conn.CreateTable<Event>();
        }
        public void AddEvent(Event newEvent)
        {
            int rowsAdded = conn.Insert(newEvent);
            App.Current.MainPage.DisplayAlert("Succes","New" + rowsAdded + "event(s) successfully added", "OK");
        }
    }
}
