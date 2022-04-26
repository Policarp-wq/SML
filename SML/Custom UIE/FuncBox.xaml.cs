using SML.Models;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;

namespace SML.Custom_UIE
{
    /// <summary>
    /// Логика взаимодействия для FuncBox.xaml
    /// </summary>
    public partial class FuncBox : UserControl, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
        public string FirstParam
        {
            get { return (string)GetValue(FirstParamProperty); }
            set { SetValue(FirstParamProperty, value); OnPropertyChanged(); }
        }

        // Using a DependencyProperty as the backing store for FirstParam.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty FirstParamProperty =
            DependencyProperty.Register("FirstParam", typeof(string), typeof(FuncBox), new PropertyMetadata(string.Empty));

        public string SecondParam
        {
            get { return (string)GetValue(SecondParamProperty); }
            set { SetValue(SecondParamProperty, value); OnPropertyChanged(); }
        }

        // Using a DependencyProperty as the backing store for SecondParam.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty SecondParamProperty =
            DependencyProperty.Register("SecondParam", typeof(string), typeof(FuncBox), new PropertyMetadata(string.Empty));

        public IEnumerable<PresentatedFunction> Functions
        {
            get { return (IEnumerable<PresentatedFunction>)GetValue(FunctionsProperty); }
            set { SetValue(FunctionsProperty, value); OnPropertyChanged(); }
        }

        // Using a DependencyProperty as the backing store for Functions.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty FunctionsProperty =
            DependencyProperty.Register("Functions", typeof(IEnumerable<PresentatedFunction>), typeof(FuncBox),
                new PropertyMetadata(Enumerable.Empty<PresentatedFunction>()));

        public PresentatedFunction SelectedFunc
        {
            get { return (PresentatedFunction)GetValue(SelectedFuncProperty); }
            set { SetValue(SelectedFuncProperty, value); OnPropertyChanged(); }
        }

        // Using a DependencyProperty as the backing store for SelectedFunc.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty SelectedFuncProperty =
            DependencyProperty.Register("SelectedFunc", typeof(PresentatedFunction), typeof(FuncBox), new PropertyMetadata(null));


        public string Answer
        {
            get { return (string)GetValue(AnswerProperty); }
            set { SetValue(AnswerProperty, value); OnPropertyChanged(); }
        }

        // Using a DependencyProperty as the backing store for Answer.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty AnswerProperty =
            DependencyProperty.Register("Answer", typeof(string), typeof(FuncBox), new PropertyMetadata(string.Empty));


        public FuncBox()
        {
            InitializeComponent();
        }
    }
}
