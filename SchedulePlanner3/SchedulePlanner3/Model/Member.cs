using System;
using System.Collections.Generic;
using System.Text;

namespace SchedulePlanner3.Model
{
    public class Member
    {
        public string name;
        public string email;
        public string password;
        public Member(string name, string email, string password)
        {
            this.name = name;
            this.email = email;
            this.password = password;
        }
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
