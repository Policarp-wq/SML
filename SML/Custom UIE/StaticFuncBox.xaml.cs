using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;

namespace SML.Custom_UIE
{

    public partial class StaticFuncBox : UserControl,  INotifyPropertyChanged
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
            DependencyProperty.Register("FirstParam", typeof(string), typeof(StaticFuncBox), new PropertyMetadata(string.Empty));

        public string SecondParam
        {
            get { return (string)GetValue(SecondParamProperty); }
            set { SetValue(SecondParamProperty, value); OnPropertyChanged(); }
        }

        // Using a DependencyProperty as the backing store for SecondParam.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty SecondParamProperty =
            DependencyProperty.Register("SecondParam", typeof(string), typeof(StaticFuncBox), new PropertyMetadata(string.Empty));

        public string FuncName
        {
            get { return (string)GetValue(FuncNameProperty); }
            set { SetValue(FuncNameProperty, value); OnPropertyChanged(); }
        }

        // Using a DependencyProperty as the backing store for NameFunc.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty FuncNameProperty =
            DependencyProperty.Register("FuncName", typeof(string), typeof(StaticFuncBox), new PropertyMetadata(string.Empty));


        public string FirstTag
        {
            get { return (string)GetValue(FirstTagProperty); }
            set { SetValue(FirstTagProperty, value); OnPropertyChanged(); }
        }

        // Using a DependencyProperty as the backing store for FirstTag.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty FirstTagProperty =
            DependencyProperty.Register("FirstTag", typeof(string), typeof(StaticFuncBox), new PropertyMetadata(string.Empty));



        public string SecondTag
        {
            get { return (string)GetValue(SecondTagProperty); }
            set { SetValue(SecondTagProperty, value); OnPropertyChanged(); }
        }

        // Using a DependencyProperty as the backing store for SecondTag.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty SecondTagProperty =
            DependencyProperty.Register("SecondTag", typeof(string), typeof(StaticFuncBox), new PropertyMetadata(string.Empty));


        public string Answer
        {
            get { return (string)GetValue(AnswerProperty); }
            set { SetValue(AnswerProperty, value); OnPropertyChanged(); }
        }

        // Using a DependencyProperty as the backing store for Answer.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty AnswerProperty =
            DependencyProperty.Register("Answer", typeof(string), typeof(StaticFuncBox), new PropertyMetadata(string.Empty));


        public StaticFuncBox()
        {
            InitializeComponent();
        }
    }
}
