using ProjectMaui.Services;
using System.IO;

namespace ProjectMaui
{
    public partial class App : Application
    {
        static DatabaseService _database;

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
        }

        public static DatabaseService Database
        {
            get
            {
                if (_database == null)
                {
                    var dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "students.db3");
                    _database = new DatabaseService(dbPath);
                }
                return _database;
            }
        }
    }
}
