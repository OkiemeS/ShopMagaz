using System;
using System.Collections.Generic;
using System.Text;

namespace ShopMagaz
{
    class Client
    {
        public string Name { get; set; }
        public byte Age { get; set; }
        public double Balanc { get; set; }
        public double Bal { get; set; } // сколько всего клиент потратил в нашем магазине
        public Client() { }
        public Client(string name, byte age, double balanc, double bal)
        {
            Name = name;
            Age = age;
            Balanc = balanc;
            Bal = bal ;
        }
        public void sumPokup(double cena)
        {
            Balanc -= cena;
            Bal += cena;
        }
    }
}
