using GamePub.Abstract;
using GamePub.Adapters;
using GamePub.Concrete;
using GamePub.Entities;
using GamePub.Kampanyalar;
using System;
using System.Collections.Generic;

namespace GamePub
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int id = 1, islem;
            string fn, ln, ni, gameName;
            double price;
            Gamer gamer = new Gamer();

            List<Game> games = new List<Game>();
            
            IGamerCheckService gamerCheckService = new MernisCheckAdapter();
            GamerManager manager = new GamerManager(gamerCheckService);
            GameManager gameManager = new GameManager();
            IShoppingService shoppingManager = new ShoppingManager();
            OcakKampanya kampanya = new OcakKampanya();

            Console.WriteLine("----- Welcome to Game Pub -----\n");
            while (true)
            {
                Console.WriteLine("1 - Kayıt ol");
                Console.WriteLine("2 - Oyun ekle");
                Console.WriteLine("3 - Oyun al");
                Console.WriteLine("4 - Oyunları listele");
                Console.WriteLine("5 - Çıkış yap");

                Console.Write("Yapmak istediğiniz işlemi seçiniz : ");
                islem = int.Parse(Console.ReadLine());

                switch (islem)
                {
                    case 1:
                        {
                            Console.Write("İsminiz : ");
                            fn = Console.ReadLine();
                            Console.Write("Soyisminiz : ");
                            ln = Console.ReadLine();
                            Console.Write("Tc NO : ");
                            ni = Console.ReadLine();
                            gamer = manager.Register(id, fn, ln, ni);
                            break;
                        }
                    case 2:
                        {
                            Console.Write("Oyun adi : ");
                            fn = Console.ReadLine();
                            Console.Write("Fiyatı : ");
                            price = double.Parse(Console.ReadLine());
                            games.Add(gameManager.AddGame(id, fn, price));
                            break;
                        }
                    case 3:
                        {
                            foreach (var item in games)
                            {
                                Console.WriteLine("Oyun : " + item.Name + " -> " + item.Price);
                            }
                            shoppingManager.Buy(gamer, games[0]);
                            break;
                        }
                    case 4:
                        {
                            foreach (var item in games)
                            {
                                Console.WriteLine("Oyun : " + item.Name + " -> " + item.Price);
                            }
                            break;
                        }
                        case 5:
                        {
                            Console.Write(games[0].Name +" : " + games[0].Price + 
                                " ocak kampanyası ile yeni fiyatı : " );
                           games[0].Price =  kampanya.GetKampanya(games[0]);
                            Console.WriteLine(games[0].Price);
                            break;
                        }
                }

            }

        }
    }
}
