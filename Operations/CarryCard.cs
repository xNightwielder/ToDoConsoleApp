using System;
using ToDoConsoleApp.Datas;

namespace ToDoConsoleApp.Operations;


class CarryCard : IOperation
{
    public static void carryCards()
    {
        Console.WriteLine("Öncelikle taşımak istediğiniz kartı seçmeniz gerekiyor.");
        Console.Write("Lütfen kart başlığını yazınız : ");
        string title = Console.ReadLine();
        bool isFounded = false;
        foreach (var item in Databases.CardList)
        {
            if (item.Title == title)
            {
                isFounded = true;
                Console.WriteLine("Bulunan Kart Bilgileri:");
                Console.WriteLine("*********************************");
                Console.WriteLine("Başlık :  " + item.Title);
                Console.WriteLine("İçerik :  " + item.Content);
                Console.WriteLine("Atanan Kişi :  " + item.PersonID);
                Console.WriteLine("Büyüklük :  " + (Databases.sizes)item.Size);
                if (item.BoardID == 1)
                {
                    Console.WriteLine("Line :  TODO");
                }
                else if (item.BoardID == 2)
                {
                    Console.WriteLine("Line :  IN PROGRESS");
                }
                else
                {
                    Console.WriteLine("Line :  DONE");
                }

                Console.WriteLine("Lütfen taşımak istediğiniz Line'ı seçiniz:");
                Console.WriteLine("(1)  TODO");
                Console.WriteLine("(2)  IN PROGRESS");
                Console.WriteLine("(3)  DONE");

                string selectedLineString = Console.ReadLine();
                int selectedLine;
                bool isSelectedStringANumber = int.TryParse(selectedLineString, out selectedLine);
                if (isSelectedStringANumber == true && (selectedLine > 0 && selectedLine <4))
                {
                    if (selectedLine == 1)
                    {
                        item.BoardID = 1;
                    }
                    else if(selectedLine == 2){
                        item.BoardID = 2;
                    }
                    else{
                        item.BoardID = 3;
                    }

                    Console.WriteLine("Kart Başarıyla Taşındı.");
                }

                else{
                    Console.WriteLine("Yanlış değer girdiniz. Tekrar deneyin");
                    carryCards();
                }
            }
        }

        if(isFounded == false){
            Console.WriteLine("Aradığınız kritere uygun kart Board'da bulunamadı. Lütfen bir seçim yapınız");
                Console.WriteLine("* Taşımayı sonlandırmak için : (1)");
                Console.WriteLine("* Yeniden denemek için : (2)");
                string controlString = Console.ReadLine();
                int control;
                bool isNumber = int.TryParse(controlString, out control);
                if (isNumber != true || (control > 2 || control <= 0))
                {
                    Console.WriteLine("Hatalı değer girdiniz.");
                }
                else
                {
                    if (control == 1)
                    {
                        Console.WriteLine("Ana Menüye Yönlendiriliyorsunuz...");
                        Program.startApplication();
                    }
                    else
                    {
                        carryCards();
                    }
                }
        }
    }


}


