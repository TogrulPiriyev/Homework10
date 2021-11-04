using System;
using System.Collections.Generic;
using System.Text;
using ClassLibrary;

namespace Homework11
{
    class User
    {
        private string _username;
        private string _password;
       
        public string Username
        {
            get
            {
                return _username;
            }
            set
            {
                if (value.Length >= 6 && value.Length <= 25)
                {
                    _username = value;
                }
                else
                {
                    throw new InvalidUserNameException("Length of word is not property");
                }
            }
        }
        public string PassWord
        {
            get
            {

                return _password;
            }
            set
            {
                
                if (value.Length >= 8 && value.Length <= 25)
                {

                    if (Check.HasDigit(value) && Check.HasLower(value) && Check.HasUpper(value)) _password=value;
                    else throw new PasswordIncorrectException("This password does not fit the criteria");
                }
                else
                {
                    throw new PasswordIncorrectException("This password does not fit the criteria");
                }
            }
        }
         public User(string username,string password)
         {
                    Username = username;
                    PassWord = password;
         }
         public virtual void ShowInfo()
         {
            Console.WriteLine($"Username:{_username},Password:{_password}");
         }
            
        
    }   
}
