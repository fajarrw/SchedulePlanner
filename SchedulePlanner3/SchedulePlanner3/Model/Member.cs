using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace SchedulePlanner3.Model
{
    [Table("members")]
    public class Member
    {
        [PrimaryKey, AutoIncrement]
        public int idMember { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        //public Member(string name, string email, string password)
        //{
        //    this.name = name;
        //    this.email = email;
        //    this.password = password;
        //}
        
        public static string getName()
        //static karena kalau tidak static tidak bisa dipakai di kelas UpdateMemberPage
        {
            string name = "nyoba pakai method getName(), perlu ambil nama dari database";
            return name;
        }

        public static string getEmail()
        //static karena kalau tidak static tidak bisa dipakai di kelas UpdateMemberPage
        {
            string email = "nyoba pakai method getEmail(), perlu ambil email dari database";
            return email;
        }
    }
}
