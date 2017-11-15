using HelloWorld.Views;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace HelloWorld
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            SetMainPage();
        }

        public static void SetMainPage()
        {
            

            Current.MainPage = new NavigationPage(new HomePage())
            {
                Title = "Hello World! + Server"
                // change in server
                // add server
            };

        }
    }
}
