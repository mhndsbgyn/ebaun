using System;
using SQLite;

namespace ebaun.DTO
{
    public class News
    {
        public News()
        {

        }
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }


        public string Egitmen_adi { get; set; }


        public string Ders_adi { get; set; }


        public int Sinif { get; set; }


        public DateTime NewsDate { get; set; }

        public string Aciklama { get; set; }



    }
}
