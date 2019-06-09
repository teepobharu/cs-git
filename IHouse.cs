using System;
using System.Collections.Generic;

namespace house
{
    interface IRent
    {
        int amount { get; set; }
        void rent(int i);
        int getPay();
    }
    interface IBuy
    {
        int amount { get; set; }
        void buy();
        int getPay();
    }
    class House : IRent, IBuy
    {
        public struct Home
        {
            public string name;
            public int price;
            public string address;
            public Home(string n, int p, string add)
            {
                name = n;
                price = p;
                address = add;
            }
        }
        public int amount { get; set; }
        private string name;
        // public List<Home> houses = new List<Home>{
        //     new Home(),
        //     new Home(),
        //     new Home(),

        // };
        //CANNOT UPDATE STRUCT properties NEED REASSIGN!
        public List<Home> houses = new List<Home>{
            new Home("asd",2,"someadd1"),
            new Home("Googlex",2,"add2"),
            new Home("H1tela",3,"someadd3"),
        };
        public House(int amount, string name)
        {
            Home h1 = new Home("asd", 4, "asd");
            h1.address = "new address";
            Console.Write(h1);
            int index = 0;
            // houses[0].price = 2;
            Console.WriteLine("House contains? {0} : {1}", houses[0].name, houses[0].price);
            while (index < houses.Count)
            {
                string address = $"Fbt + {index * 2}Street High{index}";
                houses[index] = new Home($"Changed{index}", index * 30 + 10, address);
                Console.WriteLine("House contains?  name: {0} price: {1}", houses[index].name, houses[index].price);
                index++;
            }
            this.amount = amount;
            this.name = name;
        }

        public void buy()
        {
            Console.WriteLine("Buy: " + this.amount);

        }

        public int getPay()
        {
            return amount;
        }

        public void rent(int i)
        {
            Console.WriteLine("Rent for: " + houses[i].price);
        }
    }
}