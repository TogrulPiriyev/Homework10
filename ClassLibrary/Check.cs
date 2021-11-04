using System;

namespace ClassLibrary
{
    public class Check
    {   
        
        public static bool HasDigit(string password)
        {
            
            for (int i = 0; i < password.Length; i++)
            {
                if (Char.IsDigit(password[i]))
                {
                    return true;
                }
            }
            return false;
        }
        public static bool HasUpper(string password)
        {
            for (int i = 0; i < password.Length; i++)
            {
                if (Char.IsUpper(password[i]))
                {
                    return true;
                }
            }
            return false;
        }
        public static bool HasLower(string password)
        {
            for (int i = 0; i < password.Length; i++)
            {
                if (Char.IsLower(password[i]))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
