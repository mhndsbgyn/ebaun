using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ebaun.Views;
using Newtonsoft.Json;
using System.Collections.Generic;
using ebaun.DTO;
using System.IO;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace ebaun
{
    public partial class App : Application
    {

        public App()
        {
          Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("MjQ1NzI1QDMxMzgyZTMxMmUzME5VdjFOWGZqU1VENC9KMnBxVTVYUCt3bWZJWkw0ZGoxM2F4N0xrZ0M5Y0E9");



            InitializeComponent();


            MainPage = new MainPage();
        }
        public static class StaticDB
        {
            public static List<Classes> Classes { get; private set; }
            public static List<News> News { get; private set; }
            public static List<Teacher> Teacher { get; private set; }
            

            public static void Create()
            {
                Classes = JsonConvert.DeserializeObject<List<Classes>>(AppResources.DB.Classes);
                News = JsonConvert.DeserializeObject<List<News>>(AppResources.DB.News);
                Teacher = JsonConvert.DeserializeObject<List<Teacher>>(AppResources.DB.Teacher);
              
            }
        }
        public static class Databases
        {
            static ClassesDataBase classDB;
            static NewsDataBase newsDB;
            static TeacherDataBase teacherDB;
          

            public static ClassesDataBase ClassesDataBase
            {
                get
                {
                    if (classDB == null)
                    {
                        // TODO Adres değişecek
                        classDB = new ClassesDataBase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "class.db"));
                        //cowDB = new CowDatabase("storage/10E9-2310/Android/data/com.modsoft.yildiz/cache/cows.db3");
                    }
                    return classDB;
                }
            }
            public static NewsDataBase NewsDataBase
            {
                get
                {
                    if (newsDB == null)
                    {
                        // TODO Adres değişecek
                        newsDB = new NewsDataBase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "news.db"));
                        //deviceDB = new DeviceDatabase("storage/10E9-2310/Android/data/com.modsoft.yildiz/cache/devices.db3");
                    }
                    return newsDB;
                }
            }
            public static TeacherDataBase TeacherDataBase
            {
                get
                {
                    if (teacherDB == null)
                    {
                        // TODO Adres değişecek
                        teacherDB = new TeacherDataBase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "teacher.db"));
                        //measureDB = new MeasureDatabase("storage/10E9-2310/Android/data/com.modsoft.yildiz/cache/measures.db3");
                    }
                    return teacherDB;
                }
            }
          

        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
