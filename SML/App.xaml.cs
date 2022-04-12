using System.Windows;
using SML.Stores;
using SML.ViewModels;

namespace SML
{

    public partial class App : Application
    {
        private NavigationStore _navigationStore = new NavigationStore();
        protected override void OnStartup(StartupEventArgs e)
        {
            _navigationStore.CurrentVM = new EquationSolverViewModel(_navigationStore);
            MainWindow = new MainWindow() { DataContext = new MainViewModel(_navigationStore, MainWindow) };
            MainWindow.Show();
            base.OnStartup(e);
        }
    }
}
