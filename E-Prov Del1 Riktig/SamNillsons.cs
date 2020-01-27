using System;
using System.Collections.Generic;
using System.Text;

namespace E_Prov_Del1_Riktig
{
    class SamNillsons
    {

        public string Name;
        public int Hp = 100;
        public int Starkhet = 50;
        public int Speed = 25;
        public string SuperPower;


        
        
        
        public void Printstats() //skriver ut alla variabler
        {
            Console.WriteLine(Name);
            Console.WriteLine("HP: " + Hp);
            Console.WriteLine("Starkhet: " + Starkhet);
            Console.WriteLine("Speed: " + Speed);
        }
        
        public void hurt(int dmg) //ta dmg
        {
            Hp -= dmg;
        }




    }
}
