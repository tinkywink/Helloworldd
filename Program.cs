using System;

namespace Shop
{
    class Magazine
    {
        static void Main(string[] args)
        {

            int sas = 35;
            int tom = 40;
            int pot = 25;
            


            Console.WriteLine("Hi! Welcome to TheLoopy Shop!");
            Console.ReadKey();
            Console.WriteLine($"Products: a) LoupySasauge (35 tg per kg) b) LoupyTomato (40 tg per kg) c) LoupyPotatoes(25 tg per kg)");


            Console.WriteLine("U choice: ");

            String choos = Console.ReadLine();



            if (choos == "a")
            {
                Console.WriteLine("U choice LoupySasauge");
            }
            else if (choos == "b")
            {
                Console.WriteLine("U choice LoupyTomato");

            }
            else if (choos == "c") 
            { Console.WriteLine("U choice LoupyPotatoes"); } 
            else if (choos == " ")
            {
                Console.WriteLine("idk wtf u need");

            }// тут я хотел замутить чтобы на другие буква выдавал, но там надо через бул чи шо?
            

            

            Console.WriteLine("How many kg u need: ");

            string kg = Console.ReadLine();
            int d = Convert.ToInt32(kg);
            int a = sas * d;
            int b = tom * d;
            int c = pot * d; //эти формулы самое тяжелое. пока додумал, ебать систему придумал, а потом подумал просто в начале написать их



            if (choos == "a")
            {
                Console.WriteLine($"Price: {a}");
            }
            else if (choos == "b")
            {
                Console.WriteLine($"Price: {b} ");
            }
            else if (choos == "c")
            {
                Console.WriteLine($"Price: {c}");
            }

            Console.WriteLine("Thank you for your purchase!");
            Console.ReadKey();




        }


    }
}
