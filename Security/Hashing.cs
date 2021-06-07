using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Cryptography;

namespace Security
{
    public class Hashing
    {
        public static string PasswordHashing(string password)
        {
            SHA256CryptoServiceProvider sha256 = new SHA256CryptoServiceProvider();

            byte[] passwordBytes = Encoding.ASCII.GetBytes(password);
            byte[] hashedPasswordBytes = sha256.ComputeHash(passwordBytes);

            return Convert.ToBase64String(hashedPasswordBytes);
        }
    }
}
