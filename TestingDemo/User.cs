using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingDemo
{
    public class User
    {
        private string _name;
        public string Name
        {
            get => _name;
            set
            {
                if (value == null) { throw new ArgumentNullException(); }
                if (value.Length < 2) { throw new ArgumentException(); }
                else
                    _name = value;
            }
        }

        private int _phoneNo;

        public int PhoneNo
        {
            get => _phoneNo;
            set
            {
                if (value != 8)
                {
                    throw new ArgumentOutOfRangeException();
                }
                else _phoneNo = value;
            }
        }

        public User(string name)
        {
            Name = name;
        }
    }
}
