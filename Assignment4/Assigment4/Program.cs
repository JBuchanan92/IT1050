using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment4
{
    class Program
    {
        static void Main(string[] args)
        {

            double totalCost = 0;
            double totalDiscount = 0;
            double finalCost = 0;

            Console.WriteLine("Which tickets are you interested in purchasing? ");

            Console.Write("Child-Day: ");
            int dayChildTickets = int.Parse(Console.ReadLine());

            Console.Write("Adult-Day: ");
            int dayAdultTickets = int.Parse(Console.ReadLine());

            Console.Write("Senior-Day: ");
            int daySeniorTickets = int.Parse(Console.ReadLine());

            Console.Write("Child-Evening: ");
            int eveChildTickets = int.Parse(Console.ReadLine());

            Console.Write("Adult-Evening: ");
            int eveAdultTickets = int.Parse(Console.ReadLine());

            Console.Write("Senior-Evening: ");
            int eveSeniorTickets = int.Parse(Console.ReadLine());


            Console.WriteLine();
            Console.WriteLine("What concession items (if any) would you like to buy?");


            Console.Write("Candy: ");
            int candyCount = int.Parse(Console.ReadLine());            

            Console.Write("Small Soda: ");
            int smallSodaCount = int.Parse(Console.ReadLine());

            Console.Write("Hot Dog: ");
            int hotDogCount = int.Parse(Console.ReadLine());

            Console.Write("Popcorn: ");
            int popCornCount = int.Parse(Console.ReadLine());

            Console.Write("Large Soda: ");
            int largeSodaCount = int.Parse(Console.ReadLine());

            totalCost += dayChildTickets * Prices.ChildDayTicket;            
            totalCost += daySeniorTickets * Prices.SeniorDayTicket;
            totalCost += dayAdultTickets * Prices.AdultDayTicket;
            totalCost += eveChildTickets * Prices.ChildDayTicket;            
            totalCost += eveSeniorTickets * Prices.SeniorDayTicket;
            totalCost += eveAdultTickets * Prices.AdultDayTicket;

            int totalDayTicketCount = dayChildTickets + dayAdultTickets + daySeniorTickets;
            int totalEveTicketCount = eveChildTickets + eveAdultTickets + eveSeniorTickets;
            int totalTicketCount = totalDayTicketCount + totalEveTicketCount;

            totalCost += largeSodaCount * Prices.LargeSoda;
            totalCost += smallSodaCount * Prices.SmallSoda;
            totalCost += hotDogCount * Prices.HotDog;
            totalCost += popCornCount * Prices.Popcorn;
            totalCost += candyCount * Prices.Candy;

          
            int min1 = Math.Min(popCornCount, largeSodaCount);
            int min2 = Math.Min(min1, totalTicketCount);

            totalDiscount += (min2 + 2.0);

            
            if (totalEveTicketCount >= 3 && popCornCount >= 1)
            {
                totalDiscount += Prices.Popcorn;
            }
           
            totalDiscount += (candyCount / 4) * Prices.Candy;

            finalCost = totalCost - totalDiscount;

            Console.WriteLine();
            Console.WriteLine("You saved " + totalDiscount + "!");
            Console.Write("Your total is: " + finalCost);

            Console.ReadKey();
        }
    }
}
