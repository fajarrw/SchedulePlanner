using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace SchedulePlanner3.Model
{
    [Table("events")]
    public class Event
    {
        [PrimaryKey, AutoIncrement]
        public int idEvent { get; set; }
        public int idMember { get; set; }
        public string title { get; set; }
        public string category { get; set; }
        public DateTime startDate { get; set; }
        public DateTime startTime { get; set; }
        public DateTime finishDate { get; set; }
        public DateTime finishTime { get; set; }
        public Event(string title, int idMember, string category, DateTime startDate, DateTime startTime, DateTime finishDate, DateTime finishTime)
        {
            this.title = title;
            this.idMember = idMember;
            this.category = category;
            this.startDate = startDate;
            this.startTime = startTime;
            this.finishDate = finishDate;
            this.finishTime = finishTime;
        }
    }
}
