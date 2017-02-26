using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_ATM_Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Boolean check = false;
            do
            {
                Console.WriteLine("Put Money : ");
                int money = Convert.ToInt32(Console.ReadLine());
                int bank1000 = money / 1000;
                money = money % 1000;
                int bank500 = money / 500;
                money = money % 500;
                int bank100 = money / 100;
                money = money % 100;
                int bank10 = money / 10;
                if (bank10 == 0){
                    Console.WriteLine("Bank100 : {0} Bank500 : {1} Bank1000 : {2} ", bank100, bank500, bank1000);
                    Console.ReadLine();
                    check = true;
                }
            } while (check == false);
        
           
        }
    }
}
