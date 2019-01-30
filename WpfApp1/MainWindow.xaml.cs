using Ex42_Implementing_Layers.Application;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, IObserver
    {
        private string _message;
        public string Message
        {
            get { return _message; }
            set { _message = value; }
        }
        private IObservable Observable;
        public MainWindow()
        {
            InitializeComponent();
        }
        public MainWindow(IObservable observable, string name)
        {
            Observable = observable;

        }

        public void Update(string message, IObservable observable)
        {
            Message = message;
            Observable = observable;
        }
    }
}
