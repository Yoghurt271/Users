using System;

namespace ConsoleApp15
{
    class Program
    {
        static void Main(string[] args)
        {
            Cotegory[] cotegories = new[] { new Cotegory("Строительные инструменты", new Tovar[] { new Tovar("Перфоратор", 2, 3),
                                                                              new Tovar("Молотки", 1, 2)}) };

            Cotegory[] cotegories1 = new[] { new Cotegory("Хозяйственые товары", new Tovar[] { new Tovar("Грабли", 2, 4),
                                                                              new Tovar("Ведра", 3, 5)}) };
            foreach (var cotegory in cotegories)
            {
                Console.WriteLine(cotegory.Namecot);
                foreach (var Tovar in cotegory.Tovars)
                {
                    Console.WriteLine(Tovar.Name + " " + Tovar.Coast + " " + Tovar.Rate);
                }

            }
            foreach (var cotegory in cotegories1)
            {
                Console.WriteLine(cotegory.Namecot);
                foreach (var Tovar in cotegory.Tovars)
                {
                    Console.WriteLine(Tovar.Name + " " + Tovar.Coast + " " + Tovar.Rate);
                }
                
            }
            User[] users = new[] {new User("login1", "password1", new Basket[] {new Basket(new Tovar[] {new Tovar("Перфоратор", 10, 5),
                                                                                                        new Tovar("Молотки", 2,4)})}),
                                  new User("login2", "password2", new Basket[] {new Basket(new Tovar[] {new Tovar("Грабли", 3, 5),
                                                                                                        new Tovar("Ведра", 5,3)})})};
            foreach (var user in users)
            {
                Console.WriteLine(user.Login + " " + user.Password);
                foreach (var basket in user.Baskets)
                {
                    foreach (var Tovar in basket.Buytovar)
                    {
                        Console.WriteLine(Tovar.Name + " " + Tovar.Coast + " " + Tovar.Rate);
                    }
                }
               
            }

        }
    }
}
