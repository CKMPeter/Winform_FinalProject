using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject_WinForm
{
    public class User
    {
        private string name;
        private string password;
        private string email;
        private string address;
        private int gender;
        private string avatar;
        private int rating;
        public Cart cart;
        public string Name { get { return name; }set { name = value; } }
        public string Password { get { return password; }set { password = value; } }
        public string Email { get { return email; }set { email = value; } }
        public string Address { get { return address; }set { address = value; } }
        public int Gender { get { return gender; } set { gender = value; } }
        public string Avatar { get { return avatar; } set { avatar = value; } }
        public int Rating { get { return rating; } set { rating = value; } }
        public Cart Cart { get { return cart; } set { cart = value; } }
        //Constructor

        public User(string name, string password, string address, string email, int gender, string avatar, int rating)
        {
            this.name = name;
            this.password = password;
            this.address = address;
            this.email = email;
            this.gender = gender;
            this.avatar = avatar;
            this.rating = rating;
        }
        
    }
}
