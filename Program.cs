using System;

namespace ShopMagaz
{
    class Program
    {
        static void Main(string[] args)
        {
            Informer informer = new Informer();
            Client client_1 = new Client("Гриша", 22, 50000, 450);

            Afrodeziak afrodeziak = new Afrodeziak(
                "Вазилин твоего соседа дяди Гришы"
                , "Вазилин стрит билдниг", 
                2000,
                "очищенная смесь полутвердых, твердых и жидких углеводородов");
            Kukla kukla = new Kukla(
                "Кукла Тётенька Света",
                "Васька - кукольных дел мастер Корпорейшен",
                3000,
                "резина");
            Strapon strapon = new Strapon(
                "Коньский член",
                "ООО Чудеса на Виражах",
                1450,
                32);
            ElectroStrapon electroStrapon = new ElectroStrapon("Хер циклопа 3000 PRO",
                "Щелка в кайфе Компани",
                2800,
                24,
                "24 ");
            Towar[] assortiment = new Towar[] {
            afrodeziak,
            kukla,
            strapon,
            electroStrapon
            };

            while (true)
            {
                Console.WriteLine($"\n Здравствуйте {client_1.Name} ваш баланс {client_1.Balanc} \n Список ассортимента : ");
                for (int i = 0; i < assortiment.Length; i++)
                {
                    Console.WriteLine($"\n Товар номер {i}\n");
                    assortiment[i].info();
                }
                Console.WriteLine(" Введите название товара, которое хотите купить ");
                string str = Console.ReadLine();
                int NamePokupki = Convert.ToInt32(str);

                if (NamePokupki > -1 && NamePokupki < assortiment.Length)
                {
                    if (assortiment[NamePokupki].Cena < client_1.Balanc)
                    {
                        informer.infoskyp(client_1, assortiment[NamePokupki]);
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("У вас недостаточно средств");
                    }
                }
                else
                {
                    Console.WriteLine(" Таких товаров нет");
                }
            }
        }
    }
}
