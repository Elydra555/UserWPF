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
using usercontrolbruh.Data;
using usercontrolbruh.Models;

namespace usercontrolbruh
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<User> Users;
        public UsersContext context;
        public MainWindow()
        {
            InitializeComponent();
            Users = new ObservableCollection<User>();
            context = new UsersContext();

            //Init();
            RefreshUsers();

            lbUsers.ItemsSource = Users;
            spInput.DataContext = Users;
        }

        private void RefreshUsers()
        {
            Users.Clear();
            foreach(var item in context.Users)
            {
                Users.Add(new User(item.Name, item.Email));
            }
        }

        private void Init()
        {
            context.Users.Add(new User("Józsa Béla", "bela@gmail.com"));
            context.Users.Add(new User("Bálint Dezső", "bdezso@gmail.com"));
            context.SaveChanges();
        }

        private void StackPanel_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            //Users.Add(new User("Sallai András", "sallai@gmail.com"));
            User user = lbUsers.SelectedItem as User;
            if (user != null)
            {
                user = new User();
            }
            //MessageBox.Show(user.Name);
            user.Id = 0;
            context.Users.Add(user);
            context.SaveChanges();
            RefreshUsers();
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
