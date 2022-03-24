using SML.Stores;
using SML.ViewModels;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace SML
{

    public partial class App : Application
    {
        private NavigationStore _navigationStore = new NavigationStore();
        protected override void OnStartup(StartupEventArgs e)
        {
            _navigationStore.CurrentVM = new HomeViewModel(_navigationStore);
            MainWindow = new MainWindow() { DataContext = new MainViewModel(_navigationStore) };
            MainWindow.Show();
            base.OnStartup(e);
        }
    }
}
