using System;
using SQLite;

namespace ebaun.DTO
{
    public class Teacher
    {
        public Teacher()
        {

        }
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Email { get; set; }

        public string Sifre { get; set; }

    }
}
