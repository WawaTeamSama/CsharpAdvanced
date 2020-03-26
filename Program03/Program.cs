using System;

namespace Program03
{
    class Program
    {
        static void Main(string[] args)
        {
            Ticket t = new Ticket(distance: 550);
            t.ShowTicket();
            Console.ReadKey();
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
