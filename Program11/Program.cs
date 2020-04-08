using System;
using System.Collections.Generic;

namespace Program11

{
    class Program
    {
        //public enum FirstName
        //{
        //    张,
        //    杨,
        //    丁,
        //    吴,
        //    郝

        //}
        //public enum LastName
        //{
        //    四,
        //    三,
        //    斌,
        //    陵,
        //    依,
        //    艺
        //}
        private static void GetRandomChineseName (ref string fName,ref string iName)
        {
            string[] fNames = new string[] 
            {
                "白","毕","卞","蔡","曹","岑","常","车","陈","成" ,"程","池","邓","丁","范","方","樊","费","冯","符"
                ,"傅","甘","高","葛","龚","古","关","郭","韩","何" ,"贺","洪","侯","胡","华","黄","霍","姬","简","江"
                ,"姜","蒋","金","康","柯","孔","赖","郎","乐","雷" ,"黎","李","连","廉","梁","廖","林","凌","刘","柳"
                ,"龙","卢","鲁","陆","路","吕","罗","骆","马","梅" ,"孟","莫","母","穆","倪","宁","欧","区","潘","彭"
                ,"蒲","皮","齐","戚","钱","强","秦","丘","邱","饶" ,"任","沈","盛","施","石","时","史","司徒","苏","孙"
                ,"谭","汤","唐","陶","田","童","涂","王","危","韦" ,"卫","魏","温","文","翁","巫","邬","吴","伍","武"
                ,"席","夏","萧","谢","辛","邢","徐","许","薛","严" ,"颜","杨","叶","易","殷","尤","于","余","俞","虞"
                ,"元","袁","岳","云","曾","詹","张","章","赵","郑" ,"钟","周","邹","朱","褚","庄","卓"
            };
            string iNames = "喜欢捉弄却总是掉入自己的陷阱今天就忘了那些欲擒故纵的把戏我要去敲你的窗";
            var rnd = new Random(DateTime.Now.Second);
            fName = fNames[rnd.Next(fNames.Length - 1)];
            iName = iNames.Substring(rnd.Next(0, iNames.Length - 1), 1) +
                iNames.Substring(rnd.Next(0, iNames.Length - 1), 1);
        }


        //随机初始化100个员工
        public static List<Person> GetPersons()
        {
            List<Person> lp = new List<Person> { };
            
            for(int i = 0; i < 100; i++)
            {
                Person p = new Person();
                var firstname = "";
                var lastname = "";
                GetRandomChineseName(ref firstname, ref lastname);
                p.FirstName=firstname;
                p.LastName = lastname;
                lp.Add(p);
            }
            return lp;
        }

        static void Main(string[] args)
        {
            var firstname = "";
            var lastname = "";
            GetRandomChineseName(ref firstname, ref lastname);
            Console.WriteLine(firstname + lastname);
            List<Person> p = GetPersons();
            foreach(Person i in p)
            {
                Console.WriteLine(i.FirstName+i.LastName);
            }

        }
       
    }
}
