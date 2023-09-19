using ProfilePageJaara.MVVM.Views;

namespace ProfilePageJaara
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new DataView();
        }
    }
}