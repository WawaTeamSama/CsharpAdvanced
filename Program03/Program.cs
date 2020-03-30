using System;
using System.Collections;

namespace Program03
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[] { 1, 3, 5 };
            ArraList arr = new ArraList();
            for (int i = 0; i < num.Length; i++)
            {
                arr.Add(num[i]);
            }
            arr.Insert(1, 4);
            Console.Write(arr[2]);
        }
    }
    public class Ticket
    {
        public  double  Distance { get;}

        public Ticket(double distance)
        {
            this.Distance = distance > 0 ? distance:0;
            this.Price = distance > 0 && distance <= 100 ? distance : distance > 100 && distance <= 200 ? 0.95 * distance : distance > 200 && distance <= 300 ? 0.9 * distance : distance > 300 ? 0.85 * distance : 0;

        }

        

        public double Price { get; }    
        public  void ShowTicket()
        {
            Console.WriteLine(Price);
        }
    }
}
