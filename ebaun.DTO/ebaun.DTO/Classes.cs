using System;
using SQLite;

namespace ebaun.DTO
{
    public class Classes
    {
        public Classes()
        {

        }
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Ders_adi { get; set; }
        public string Egitmen_adi { get; set; }
        public int Sinif { get; set; }

    }
}
