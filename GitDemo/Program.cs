using System;
using System.Linq;

namespace GitDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] arrOfNum = new int[5];
            arrOfNum[0] = 13;
            arrOfNum[1] = 22;
            arrOfNum[2] = 3;
            arrOfNum[3] = 93;
            arrOfNum[4] = 1;
  
            Console.WriteLine("Check if you picked a lucky number");
            string nr = Console.ReadLine();
            int myNr = Convert.ToInt32(nr);

            for(int i=0; i < arrOfNum.Length; i++ ) // (startvärdet, villkoret/hur länge skall koden köras, förändring/värdet i plussas med 1 )
            {
                if(myNr == arrOfNum[i])
                {
                    Console.WriteLine("Winner winner chicken dinner");
                    break;
                } else
                {
                    Console.WriteLine("Not this time");
                }
            }
            Console.WriteLine(arrOfNum.Contains(3));

        }
    }
}
