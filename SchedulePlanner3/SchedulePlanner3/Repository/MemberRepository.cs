using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using SchedulePlanner3.Model;

namespace SchedulePlanner3.Repository
{
    public class MemberRepository
    {
        SQLiteConnection conn;
        public MemberRepository(string dbPath)
        {
            conn = new SQLiteConnection(dbPath);
            conn.CreateTable<Member>();
        }
        public int AddMember(Member newMember)
        {
            int rowsAdded = conn.Insert(newMember);
            return rowsAdded;        
        }
        public bool Authenticate(string email, string password)
        {
            Member memberFromDatabase = conn.Table<Member>().Where(i => i.email == email).FirstOrDefault();
            if (memberFromDatabase != null)
            {
                if (memberFromDatabase.password == password)
                    return true;
                else
                    return false;
            }
            else
                return false;
            //string passwordFromDatabase = conn.Query<Member>("from member in members where member.email == email select member.password").ToString();
            //if (passwordFromDatabase == password)
            //    return true;
            //else
            //    return false;
        }
    }
}
