using System;

namespace ToDoConsoleApp.Datas
{
    class Databases
    {
        private static List<TeamPerson> _personList = new List<TeamPerson>();
        private static List<Card> _cardList = new List<Card>();
        public static List<TeamPerson> PersonList => _personList;
        public static List<Card> CardList => _cardList;

        public static void createDefaultPersons(){
            
            _personList = new List<TeamPerson>(){
                new TeamPerson(1,"Ahmet","Özkaynak"),
                new TeamPerson(2,"Melisa","Yılmaz"),
                new TeamPerson(3,"Sude","Candan"),
                new TeamPerson(4,"Asya","Candan"),
                new TeamPerson(5,"Niyazi","Sağlam")
            };
            
        }

        public static void createDefaultCards(){
            _cardList = new List<Card>(){
                new Card(1,1,"Yapılacak İş 1","İş İçeriği 1",2),
                new Card(2,2,"Yapılacak İş 2","İş İçeriği 2",1),
                new Card(3,3,"Yapılacak İş 3","İş İçeriği 3",3),
            };
        }

        public enum sizes
        {
            XS =1,
            S,
            M,
            L,
            XL

        }

        
    }

}