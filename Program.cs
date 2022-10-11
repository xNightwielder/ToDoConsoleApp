using System.Collections;
using System;
using ToDoConsoleApp.Datas;
using ToDoConsoleApp.Operations;


namespace ToDoConsoleApp;

class Program
{
    static void Main(string[] args)
    {
        Databases.createDefaultPersons();
        Databases.createDefaultCards();

        bool anaEkran = true;

        while (anaEkran)
        {
            startApplication();
        }




    }

    public static void startApplication(){
        Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :)");
            Console.WriteLine("*******************************************");
            Console.WriteLine("(1) Board Listelemek");
            Console.WriteLine("(2) Board'a Kart Eklemek");
            Console.WriteLine("(3) Board'dan Kart Silmek");
            Console.WriteLine("(4) Kart Taşımak");

            string enteredValue = Console.ReadLine();
            int accessValue;
            bool isNumber = int.TryParse(enteredValue, out accessValue);
            if (isNumber == true)
            {
                if (accessValue == 1)
                {
                    ListCards.listCards();
                }
                if (accessValue == 2)
                {
                    AddNewCard.addNewCards();
                }
                if(accessValue == 3){
                    DeleteCard.deleteCards();
                }
                if(accessValue == 4){
                    CarryCard.carryCards();
                }
            }
    }
}
