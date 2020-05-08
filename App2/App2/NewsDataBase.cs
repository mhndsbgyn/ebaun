using SQLite;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ebaun.DTO;
using Xamarin.Forms;

namespace ebaun
{
    public class NewsDataBase
    {
        SQLiteConnection veritabaniBaglantisi;
        public News()
        {
            veritabaniBaglantisi = DependencyService.Get<SqlConnection>().BaglantiyiAl();
            veritabaniBaglantisi.CreateTable<News>();
        }
        public int Kaydet(News model)
        {
            return veritabaniBaglantisi.Insert(model);
        }

        public int Guncelle(News model)
        {
            return veritabaniBaglantisi.Update(model);
        }
        public int Sil(News model)
        {
            // Birden fazla talo olabilir bu yüzden hangi tablodaysa ona göre belirtmemiz gerekiyor.
            return veritabaniBaglantisi.Delete<News>(model);
        }
        public IEnumerable<News> Listele()
        {
            return veritabaniBaglantisi.Table<News>();
        }
        public News Getir(int ID)
        {
            return veritabaniBaglantisi.Table<News>().Where(x => x.ID == ID).FirstOrDefault();
        }

        public void Kapat()
        {
            veritabaniBaglantisi.Dispose();
        }
    }
}
