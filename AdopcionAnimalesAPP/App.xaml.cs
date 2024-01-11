using AdopcionAnimalesAPP.Service;

namespace AdopcionAnimalesAPP
{
    public partial class App : Application
    {
       // public static ApiService ApiService { get; set; } 
        public App()
        {
            InitializeComponent();
            //ApiService = new ApiService();
            MainPage = new NavigationPage(new PrincipalPage());
        }
    }
}
