using System;
using ToDoConsoleApp.Datas;

namespace ToDoConsoleApp.Operations;


    class ListCards : IOperation
    {
        public static void listCards(){
            Console.WriteLine("TODO Line");
            Console.WriteLine("******************");
            foreach(var item in Databases.CardList){
                if(item.BoardID == 1){
                    Console.WriteLine("Başlık : " + item.Title);
                    Console.WriteLine("İçerik : " + item.Content);
                    Console.WriteLine("Atanan Kişi : " + item.PersonID);
                    Console.WriteLine("Büyüklük : " + (Databases.sizes)item.Size);
                    Console.WriteLine("-");
                }
            }
            Console.WriteLine("IN PROGRESS Line");
            Console.WriteLine("******************");
            foreach(var item in Databases.CardList){
                if(item.BoardID == 2){
                    Console.WriteLine("Başlık : " + item.Title);
                    Console.WriteLine("İçerik : " + item.Content);
                    Console.WriteLine("Atanan Kişi : " + item.PersonID);
                    Console.WriteLine("Büyüklük : " + (Databases.sizes)item.Size);
                    Console.WriteLine("-");
                }
            }
            Console.WriteLine("DONE Line");
            Console.WriteLine("******************");

            foreach(var item in Databases.CardList){
                if(item.BoardID == 3){
                    Console.WriteLine("Başlık : " + item.Title);
                    Console.WriteLine("İçerik : " + item.Content);
                    Console.WriteLine("Atanan Kişi : " + item.PersonID);
                    Console.WriteLine("Büyüklük : " + (Databases.sizes)item.Size);
                    Console.WriteLine("-");
                }
            }

        }
        
    }

    