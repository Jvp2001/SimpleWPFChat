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

namespace SimpleChat
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        private WindowState CurrentWindowState
        {
            get => Application.Current.MainWindow!.WindowState;
            set => Application.Current.MainWindow!.WindowState = value;
        }

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if(e.LeftButton == MouseButtonState.Pressed)
                DragMove();
            
        }
        
        private void MinimiseButton_Click(object sender, RoutedEventArgs e)
        {
            CurrentWindowState = WindowState.Minimized;
        }
 
        private void WindowStateChangeButton_Click(object sender, RoutedEventArgs e)
        {
            CurrentWindowState =
                CurrentWindowState != WindowState.Maximized ? WindowState.Minimized : WindowState.Normal;
        }
        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown(0);
        }

    

    }
}