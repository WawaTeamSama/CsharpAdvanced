using System;

namespace Program12Encyption
{
    class Program
    {
        static void Main(string[] args)
        {
            string pwd = "k23124";
            Console.WriteLine("明文:" + pwd);
            string md5Pwd = Encpytion.GetMd5(pwd);
            Console.WriteLine("MD5密文:" + md5Pwd);
            string SHAPwd = Encpytion.GetSHA(pwd);
            Console.WriteLine("SHA密文" + SHAPwd);
        }
    }
}
