using System;

namespace E_Prov_Del1_Riktig
{
    class Program
    {

        public string answer;
        

        static void Main(string[] args)
        {


            Console.WriteLine("Hello Shounen!");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("You are a superhero enrolling in the school Superhero Academy!");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Please chose what kind of superhero you want to be!");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("1. Neandertalare");
            Console.WriteLine("2. Sam Nillson");
            Console.WriteLine("3. Edgelord");
            string answer = Console.ReadLine();
            if (answer != "1")
            {
                Console.WriteLine("Please type 1, 2 or 3");
            }
            if (answer != "2")
            {
                Console.WriteLine("Please type 1,2 or 3");
            }
            if (answer != "3")
            {
                Console.WriteLine("Please type 1,2 or 3");
            }
            if (answer == "1") //du valde nti elev
            {
                Neandertalare myNeandertalare = new Neandertalare();
                Console.WriteLine("You have chosen to be a neandertalare!");
                Console.WriteLine("What is your name?");
                myNeandertalare.Name = Console.ReadLine();
                Console.WriteLine("You have chosen " + myNeandertalare.Name + "! Great name!");
            }
            if (answer == "2") //´du valde Sam
            {
                SamNillson mySamNillson = new SamNillson();
                Console.WriteLine("You have chosen to be Sam Nillson");
                Console.WriteLine("What is your name?");
                mySamNillson.Name = "Sam Nillson";
                Console.WriteLine("You have chosen Sam Nillson! Great name!");
            }
            if (answer == "3") //du valde edgelord
            {
                Edgelord myEdgelord = new Edgelord();
                Console.WriteLine("You have chosen to be an Edgelord");
                Console.WriteLine("What is your name?");
                myEdgelord.Name = Console.ReadLine();
                Console.WriteLine("You have chosen " + myEdgelord.Name + "! Great name!");




            }

        


        
    }
}
