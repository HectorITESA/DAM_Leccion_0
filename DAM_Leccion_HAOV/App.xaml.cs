using DAM_Leccion_HAOV.View;

namespace DAM_Leccion_HAOV
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            //MainPage = new AppShell();
            MainPage = new PersonasView();
        }

    }
}