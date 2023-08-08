using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace HashMachine
{
    internal class MacHandler
    {

        private const int KeySize = 32;


        public static byte[] GenerateKey()
        {
            var randomNumberGenerator = RandomNumberGenerator.Create();
            byte[] randomBytes = new byte[KeySize]; // Brug length parameteren til at bestemme antallet af bytes
            randomNumberGenerator.GetBytes(randomBytes);

            return randomBytes;


        }

        public static byte[] ComputeHmacmd5(byte[] toBeHashed, byte[] key)
        {
            using (var hmac = new HMACMD5(key))
            {
                return hmac.ComputeHash(toBeHashed);
            }
        }

        public static byte[] ComputeHmacsha1(byte[] toBeHashed, byte[] key)
        {
            using (var hmac = new HMACSHA1(key))
            {
                return hmac.ComputeHash(toBeHashed);
            }
        }

        public static byte[] ComputeHmacsha256(byte[] toBeHashed, byte[] key)
        {
            using (var hmac = new HMACSHA256(key))
            {
                return hmac.ComputeHash(toBeHashed);
            }
        }

        public static byte[] ComputeHmacsha384(byte[] toBeHashed, byte[] key)
        {
            using (var hmac = new HMACSHA384(key))
            {
                return hmac.ComputeHash(toBeHashed);
            }
        }

        public static byte[] ComputeHmacsha512(byte[] toBeHashed, byte[] key)
        {
            using (var hmac = new HMACSHA512(key))
            {
                return hmac.ComputeHash(toBeHashed);
            }
        }


    }


}

