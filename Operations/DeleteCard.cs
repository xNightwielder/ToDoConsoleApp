using System;
using ToDoConsoleApp.Datas;

namespace ToDoConsoleApp.Operations;


class DeleteCard : IOperation
{
    public static void deleteCards()
    {
        Console.WriteLine("Öncelikle silmek istediğiniz kartı seçmeniz gerekiyor.");
        Console.Write("Lütfen kart başlığını yazınız : ");
        string lookForTitle = Console.ReadLine();

        bool isFound = false;
        foreach (var item in Databases.CardList)
        {
            if (item.Title == lookForTitle)
            {
                Databases.CardList.Remove(item);
                isFound = true;
                Console.WriteLine(lookForTitle + " başlıklı Kart başarıyla silindi.");
                break;
            }
        }
    

        if(isFound == false){
            Console.WriteLine("Aradığınız kritere uygun kart Board'da bulunamadı. Lütfen bir seçim yapınız");
                Console.WriteLine("* Silmeyi sonlandırmak için : (1)");
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
                        deleteCards();
                    }
                }
        }
    }
}
