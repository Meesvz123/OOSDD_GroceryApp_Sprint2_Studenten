using Grocery.App.Views;
using Grocery.App.ViewModels;

namespace Grocery.App
{
    public partial class App : Application
    {
        public App(LoginViewModel viewModel) { 
        
            InitializeComponent();

            MainPage = new LoginView(viewModel);
        }
    }
}
