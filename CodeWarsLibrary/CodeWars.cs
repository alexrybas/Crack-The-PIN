using System.ComponentModel;
using System.Security.Cryptography;
using System.Text;

namespace CodeWarsLibrary
{
    public class CodeWars
    {
 
        public static string crack(string hash)
        {
            string password = string.Empty;

            for (int i = 0; i <= 99999; i++)
            {
                password = i.ToString();
                password = password.PadLeft(5, '0');

                if (hash == MD5Hash(password))
                {
                    break;
                }

            }
            return password;
        }

        public static string MD5Hash(string message)
        {
            byte[] hash = MD5.Create().ComputeHash(Encoding.UTF8.GetBytes(message));
            string hexString = Convert.ToHexString(hash);
            hexString = hexString.ToLower();

            return hexString;
        }
    }
}