using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using usercontrolbruh.Models;

namespace usercontrolbruh
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<User> Users;
        public MainWindow()
        {
            InitializeComponent();
            Users = new ObservableCollection<User>();
            Users.Add(new User("Józsa Béla", "bela@gmail.com"));
            Users.Add(new User("Bálintr Dezső", "bdezso@gmail.com"));
            lbUsers.ItemsSource = Users;
            spInput.DataContext = Users;
        }

        private void StackPanel_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            Users.Add(new User("Sallai András", "sallai@gmail.com"));
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
