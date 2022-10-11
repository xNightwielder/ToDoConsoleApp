using System;
using ToDoConsoleApp.Datas;

namespace ToDoConsoleApp.Operations;


class AddNewCard : IOperation
{
    public static void addNewCards()
    {
        Console.Write("Başlık Giriniz : ");
        string title = Console.ReadLine();

        Console.Write("\nİçerik Giriniz : ");
        string content = Console.ReadLine();

        Console.Write("\nBüyüklük Seçiniz -> XS(1),S(2),M(3),L(4),XL(5) : ");
        string sizeString = Console.ReadLine();
        int size;
        bool isNumber = int.TryParse(sizeString, out size);

        Console.Write("\nKişi ID Giriniz : ");
        string personString = Console.ReadLine();

        int person;
        bool isNumber2 = int.TryParse(personString, out person);

        bool isFound = false;
        foreach (var item in Databases.PersonList)
        {
            if (item.PersonID == person)
            {
                isFound = true;
            }
        }


        if (isNumber == false || isNumber2 == false || isFound == false || (size > 5 || size<1))
        {
            Console.WriteLine("Hatalı işlem yaptınız. Lütfen tekrar deneyin.");
            addNewCards();
        }
        else
        {

            Card card = new Card(person, 1, title, content, size);
            Databases.CardList.Add(card);


            Console.WriteLine("Kart başarıyla eklendi");

        }
    }

}

