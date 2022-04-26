using SML.Core;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;

namespace SML.Custom_UIE
{

    public partial class DoubleTextBox : UserControl, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
        public string First
        {
            get { return (string)GetValue(FirstProperty); }
            set { SetValue(FirstProperty, value); OnPropertyChanged(); }
        }

        // Using a DependencyProperty as the backing store for First.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty FirstProperty =
            DependencyProperty.Register("First", typeof(string),
                typeof(DoubleTextBox),
                new PropertyMetadata(string.Empty, new PropertyChangedCallback(OnFirstPropertyChanged)));

        public static readonly RoutedEvent FirstChangedEvent = EventManager.RegisterRoutedEvent("FirstChanged",
            RoutingStrategy.Bubble,
            typeof(RoutedPropertyChangedEventHandler<string>),
            typeof(DoubleTextBox));
        public event RoutedPropertyChangedEventHandler<string> FirstChanged
        {
            add { AddHandler(FirstChangedEvent, value); }
            remove { RemoveHandler(FirstChangedEvent, value); }
        }
        private static void OnFirstPropertyChanged(DependencyObject sender, DependencyPropertyChangedEventArgs e)
        {
            if(sender is DoubleTextBox)
            {
                var d = sender as DoubleTextBox;
                d.RaiseEvent(new RoutedPropertyChangedEventArgs<string>((string)e.OldValue, (string)e.NewValue, FirstChangedEvent));
            }
            
        }
        public string Second
        {
            get { return (string)GetValue(SecondProperty); }
            set { SetValue(SecondProperty, value); OnPropertyChanged(); }
        }

        // Using a DependencyProperty as the backing store for Second.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty SecondProperty =
            DependencyProperty.Register("Second", typeof(string),
                typeof(DoubleTextBox),
                new PropertyMetadata(string.Empty, OnSecondPropertyChanged));

        private static void OnSecondPropertyChanged(DependencyObject sender, DependencyPropertyChangedEventArgs e)
        {
            var d = sender as DoubleTextBox;
            
        }

        public string FirstTag
        {
            get { return (string)GetValue(FirstTagProperty); }
            set { SetValue(FirstTagProperty, value); OnPropertyChanged(); }
        }

        // Using a DependencyProperty as the backing store for FirstTag.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty FirstTagProperty =
            DependencyProperty.Register("FirstTag", typeof(string), typeof(DoubleTextBox), new PropertyMetadata(string.Empty));



        public string SecondTag
        {
            get { return (string)GetValue(SecondTagProperty); }
            set { SetValue(SecondTagProperty, value); OnPropertyChanged(); }
        }

        // Using a DependencyProperty as the backing store for SecondTag.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty SecondTagProperty =
            DependencyProperty.Register("SecondTag", typeof(string), typeof(DoubleTextBox), new PropertyMetadata(string.Empty));


        public DoubleTextBox()
        {
            InitializeComponent();
        }
    }
}
