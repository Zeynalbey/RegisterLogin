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


}
