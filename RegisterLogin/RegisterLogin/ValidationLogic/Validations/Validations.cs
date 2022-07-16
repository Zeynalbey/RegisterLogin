using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegisterLogin.ValidationLogic.Validations
{

    public class LengthValidaton
    {
        public virtual bool IsCorrect(string text)
        {
            string pattern = "^[A-Z][a-z]{2,30}$";
            Regex regex = new Regex(pattern);
            if (regex.IsMatch(text))
            {
                return true;
            }
            return false;
        }
        
    }
    public class ValidationName : LengthValidaton
    {

    }
    public class ValidationLastName : LengthValidaton
    {
        
    }
    public class ValidationEmailL
    {
        public  bool IsEmailCorrect(string email)
        {
            string pattern = @"^([a-zA-Z0-9]{2,30})(@code\.edu\.az)$";
            Regex regex = new Regex(pattern);
            if (regex.IsMatch(email))
            {
                return true;
            }
            return false;
        }
    }

    public class ValidationPassword
    {
        public bool IsPasswordCorrect(string password)
        {
            Regex hasNumber = new Regex(@"[0-9]+");
            Regex hasUpperChar = new Regex(@"[A-Z]+");
            Regex hasMiniMaxChars = new Regex(@".{8,}");
            Regex hasLowerChar = new Regex(@"[a-z]+");


            if (!hasLowerChar.IsMatch(password))
            {

                return false;
            }
            else if (!hasUpperChar.IsMatch(password))
            {
                return false;
            }
            else if (!hasMiniMaxChars.IsMatch(password))
            {
                return false;
            }
            else if (!hasNumber.IsMatch(password))
            {
                return false;
            }

            return true;
        }
    }
    


}
