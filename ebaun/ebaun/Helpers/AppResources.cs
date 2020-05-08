using Xamarin.Forms;

namespace ebaun

{
    public static class AppResources
    {
        public static class Icons
        {
            public static class Menu
            {
                public static string Duyurular { get { return "ebaun.Assets.Icons.news.png"; } }
                public static string Egitmen_Girisi { get { return "ebaun.Assets.Icons.teacher.png"; } }
                public static string Ayarlar { get { return "ebaun.Assets.Icons.Settings.png"; } }
                public static string Egitmen_Duyuru_Sayfası { get { return "ebaun.Assets.Icons.teachernews.png"; } }
                public static string Hakkında { get { return "ebaun.Assets.Icons.about.png"; } }
               

            }
        }
        public static class Colors
        {
            public static Color Primary { get { return Color.FromHex("#006f68"); } }
            public static Color Light { get { return Color.FromHex("#006f68"); } }
            public static Color Dark { get { return Color.FromHex("#006f68"); } }
        }
        public static class DB
        {
            public static string Classes = "[ " +
                                    "    { " +
                                    "        \"Id\": 5, " +
                                    "        \"Ders_adi\": matematik " +
                                    "         \"Egitmen_adi\": recep " +
                                    "         \"Sinif\": 1 " +
                                    "    } " +
                                    "] ";

            public static string News = "[ " +
                                    "    { " +
                                   "        \"Id\": 3, " +
                                    "        \"Ders_adi\": matematik " +
                                    "         \"Egitmen_adi\": recep " +
                                    "         \"Sinif\": 1 " +
                                    "        \"NewsDate\": 23/09/2020 " +
                                    "         \"Aciklama\": duyuru " +
                                 
                                    "    } " +
                                    "] ";
            public static string Teacher = "[ " +
                                    "    { " +
                                    "        \"Id\": 6, " +           
                                    "         \"Email\": recep " +
                                    "         \"Sifre\": 123 " +
                                    "    }, " +
                                 
                                    "] ";
        }
        }
}
