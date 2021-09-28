using System;
using System.Collections.Generic;
using System.Text;

namespace ShopMagaz
{
    class Towar
    {
        public string Naimenowanie { get; set; }
        public string Proizwoditel { get; set; }
        public double Cena { get; set; }
        public Towar() { }
        public Towar(string naimenowanie, string proizwoditel, double cena)
        {
            Naimenowanie = naimenowanie;
            Proizwoditel = proizwoditel;
            Cena = cena;
        }
        public double Skidos(Client client)
        {

            if (client.Bal < 300)
            {
                return Cena;
            }
            if (client.Bal < 1000)
            {
                return Cena * 0.9;
            }
            return Cena * 0.8;
        }
        public virtual void info()
        {
            Console.WriteLine($"{Naimenowanie} \n От компании: {Proizwoditel} \n Цена товара: {Cena}");
        }
    }
    class Afrodeziak : Towar
    {
        public string Sostaw { get; set; }
        public Afrodeziak (string naimenowanie, string proizwoditel, double cena, string sostaw) : base(naimenowanie, proizwoditel, cena)
        {
            Sostaw = sostaw;
        }
        public override void info()
        {
            Console.WriteLine($"{Naimenowanie} \n От компании: {Proizwoditel} \n Цена товара : {Cena} \n Состав :{Sostaw}");
        }
    }
    class Kukla : Towar
    {
        public string Material { get; set; }
        public Kukla ( string naimenowanie, string proizwoditel, double cena, string material) : base(naimenowanie, proizwoditel, cena)
        {
            Material = material;
        }
        public override void info()
        {
            Console.WriteLine($"{Naimenowanie} \n От компании: {Proizwoditel} \n Цена товара : {Cena} \n Материал :{Material}");
        }
    }
    class Strapon : Towar
    {
        public int Dlina { get; set; }
        public Strapon(string naimenowanie, string proizwoditel, double cena, int dlina) : base(naimenowanie, proizwoditel, cena)
        {
            Dlina = dlina;
        }
        public override void info()
        {
            Console.WriteLine($"{Naimenowanie} \n От компании: {Proizwoditel} \n Цена товара : {Cena} \n Длина (см) :{Dlina}");
        }
    }
    class ElectroStrapon : Strapon
    {
        public string Moschnost { get; set; }

        public ElectroStrapon(string naimenowanie, string proizwoditel, double cena, int dlina, string moschnost) : base(naimenowanie, proizwoditel, cena,dlina)
        {
            Moschnost = moschnost + "кВТ";
        }
        public override void info()
        {
            Console.WriteLine($"{Naimenowanie} \n От компании: {Proizwoditel} \n Цена товара : {Cena} \n Мащность :{Moschnost}");
        }
    }

    class Informer
    {
        public void infoskyp(Client client, Towar towar)
        {
            double cena = towar.Skidos(client);
            client.sumPokup(cena);
            Console.WriteLine($"Клиент {client.Name} купил товар {towar.Naimenowanie} по цене {cena} товар отправлен на склад ");

        }
    }
}
