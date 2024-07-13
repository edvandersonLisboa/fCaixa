using MauiApplication = Microsoft.Maui.Controls.Application;

namespace Jamboo.Desk
{
    public partial class App :  MauiApplication
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }
    }
}
