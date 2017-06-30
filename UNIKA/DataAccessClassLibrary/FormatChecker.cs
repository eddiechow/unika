using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BackendClassLibrary
{
    public class FormatChecker
    {
        public static bool isValidEmail(string email)
        {
            try
            {
                MailAddress m = new MailAddress(email);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
            catch (ArgumentNullException)
            {
                return false;
            }
        }

        public static bool checkPasswdFormat(string password)
        {
            Regex passwordFormat = new Regex("^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-])(?!.*?[\\s]).{8,}$");
            if (!passwordFormat.IsMatch(password))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool includeChineseChar(string chineseString)
        {
            bool result = true;
            int range = 0;
            int max = Convert.ToInt32("9fff", 16);
            int min = Convert.ToInt32("4e00", 16);
            for (int i = 0; i < chineseString.Length; i++)
            {
                range = Convert.ToInt32(Convert.ToChar(chineseString.Substring(i, 1)));
                if (range >= min && range < max)
                {
                    result = true;
                    break;
                }
                else
                {
                    result = false;
                }
            }

            return result;
        }
    }
}
