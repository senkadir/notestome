using NotestoMe.Views;
using Xamarin.Forms;

namespace NotestoMe
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NotesPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
