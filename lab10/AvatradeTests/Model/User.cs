using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvatradeTests.Model
{
    public class User
    {
        private string _username;
        private string _password;
        public User(string username, string password)
        {
            this._username = username;
            this._password = password;
        }
        public string Username
        {
            get
            {
                return _username;
            }
            set
            {
                _username = value;
            }
        }
        public string Password
        {
            get
            {
                return _password;
            }
            set
            {
                _password = value;
            }
        }
        public override string ToString()
        {
            return "User{username=" + this._username + 
                ", password=" + this._password;
        }
        public override bool Equals(object obj)
        {
            if (this == obj) return true;
            if (!(typeof(User).IsInstanceOfType(obj))) return false;
            User user = (User)obj;

            return Equals(_username, user._username) &&
                Equals(_password, user._password);
        }
        public override int GetHashCode()
        {
            return _username.GetHashCode() + _password.GetHashCode();
        }
    }
}
