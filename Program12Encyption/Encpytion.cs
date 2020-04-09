using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Cryptography;
using System.Text;

namespace Program12Encyption
{
    class Encpytion
    {
        public static string GetMd5(string str)
        {
            var md5 = MD5.Create();
            var bitArray = Encoding.GetEncoding("UTF-8").GetBytes(str);

            var md5BitArray = md5.ComputeHash(bitArray);
            var encrypStr = "";
            for(var i = 0; i < md5BitArray.Length; i++)
            {
                encrypStr += md5BitArray[i].ToString("x2");
            }
            md5.Clear();
            return encrypStr;
        }
        public static string GetSHA(string str)
        {
            var sha = SHA512.Create();
            var bitArray = Encoding.GetEncoding("UTF-8").GetBytes(str);

            var md5BitArray = sha.ComputeHash(bitArray);
            var encrypStr = "";
            for (var i = 0; i < md5BitArray.Length; i++)
            {
                encrypStr += md5BitArray[i].ToString("x2");
            }
            sha.Clear();
            return encrypStr;
        }
    }
}
