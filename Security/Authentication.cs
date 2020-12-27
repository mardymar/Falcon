using Shared.Models;
using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace Security
{
    public class Authentication
    {
        public static bool DoLogin(string Attempt, LocalUser TheUser)
        {
            var hasedPass = DoesStringMatchHashValue(TheUser.Salt, TheUser.Password, Attempt);

            if (hasedPass)
            {
                return true;
            }

            return false;
        }

        public static byte[] GetHashForString(string Salt, string UnhashedString)
        {
            SHA256Managed hasher = new SHA256Managed();
            byte[] unhashedInput = Encoding.UTF8.GetBytes(Salt + UnhashedString);
            return hasher.ComputeHash(unhashedInput);
        }

        public static bool DoesStringMatchHashValue(string Salt, byte[] Password, string Attempt)
        {          
            byte[] hashedAttempt = GetHashForString(Salt, Attempt);
            return Password.SequenceEqual(hashedAttempt);
        }

        public static string GenerateSalt()
        {
            StringBuilder builder = new StringBuilder();
            Random random = new Random();
            char ch;
            for (int i = 0; i < 16; i++)
            {
                ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
                builder.Append(ch);
            }
            return builder.ToString();
        }

        private static string GetSalt()
        {
            return GetSalt(64);
        }
        private static string GetSalt(int maximumSaltLength)
        {
            var salt = new byte[maximumSaltLength];
            using (var random = new RNGCryptoServiceProvider())
            {
                random.GetNonZeroBytes(salt);
            }

            return Convert.ToBase64String(salt);
        }
    }
}
