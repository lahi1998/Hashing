using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;


namespace HashMachine
{
    internal class Hash
    {
        //hasher den byte der sent igennem.
        public byte[] Hasher(byte[] Bytes, string type)
        {
            byte[] hashvalue;
            if (type == "MD5")
            {
                using (MD5 md5 = MD5.Create())
                {
                    hashvalue = md5.ComputeHash(Bytes);
                }
                return hashvalue;
            }
            else if(type == "SHA1")
            {
                using (SHA1 sha1 = SHA1.Create())
                {
                    hashvalue = sha1.ComputeHash(Bytes);
                }
                return hashvalue;
            }
            else if(type == "SHA256")
            {
                using (SHA256 sha256 = SHA256.Create())
                {
                    hashvalue = sha256.ComputeHash(Bytes);
                }
                return hashvalue;
            }
            else if(type == "SHA384")
            {
                using (SHA384 sha384 = SHA384.Create())
                {
                    hashvalue = sha384.ComputeHash(Bytes);
                }
                return hashvalue;
            }
            else if(type == "SHA512")
            {
                using (SHA512 sha512 = SHA512.Create())
                {
                    hashvalue = sha512.ComputeHash(Bytes);
                }
                Console.WriteLine("sha512");
                return hashvalue ;
            }
            else
            {
                return Bytes;
            }
            
        }
    }
}
