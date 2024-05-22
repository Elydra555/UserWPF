using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace usercontrolbruh.Models
{
    public class User : INotifyPropertyChanged
    {
        public int Id { get; set; }

        public event PropertyChangedEventHandler? PropertyChanged;

        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


        private string name;
        public string Name
        {
            get { return name; }
            set { name = value;
                OnPropertyChanged();
            }
        }  


        private string email;
        public string Email
        {
            get { return email; }
            set { email = value;
                OnPropertyChanged();
            }
        }

        public User()
        {
            Id = 0;
        }

        public User(string name, string email)
        {
            Id = 0;
            Name = name;
            Email = email;
        }

        public override string? ToString()
        {
            return $"{Name} ({Email})";
        }
    }
}
