using SQLite.Net;
using SQLite.Net.Platform.XamarinAndroid;

using ebaun;
using SQLite;


[assembly: Xamarin.Forms.Dependency(typeof(DroidBaglantisi))]
namespace ebaun
{
    public class DroidBaglantisi : SqlConnection
    {
        public SQLiteConnection BaglantiyiAl()
        {
            string yol = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            var yol2 = System.IO.Path.Combine(yol, App.VTAdi);
            var platform = new SQLitePlatformAndroid();

            var baglanti = new SQLiteConnection(platform, yol2);
            return baglanti;
        }
    }
}