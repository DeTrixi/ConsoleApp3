using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace Encrypt
{
    class RandomNumber
    {
        public byte[] GenerateRandomNumber(int length)
        {
            using var randomNumberGenerator = new RNGCryptoServiceProvider();
            var randomNumber = new byte[length];
            randomNumberGenerator.GetBytes(randomNumber);

            return randomNumber;
        }
    }
}
