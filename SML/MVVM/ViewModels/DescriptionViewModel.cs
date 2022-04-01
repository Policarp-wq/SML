using System;
using System.Windows;
using System.Windows.Input;
using SML.Commands;
using SML.Core;
using SML.Models;

namespace SML.ViewModels
{
    public class DescriptionViewModel : ObservableObject
    {
        public string DescriptionText { get; set; }
        private static string DescriptionPath = "C:/Users/Professional/source/repos/SML/SML/AdditionalFiles/Description.txt";
        
        public ICommand Close { get; } 
        public DescriptionViewModel()
        {
            try
            {
                DescriptionText =
                    StringHandler.StringArrayToString(TextManager.GetTextFromFile(DescriptionPath));
            }
            catch (Exception)
            {
                DescriptionText = "Wrong path to the description file : " + DescriptionPath;
            }
            Close = new RelayCommand((param) =>
            {
                Window window = param as Window;
                window?.Close();
            });
        }
    }
}