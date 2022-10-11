using System;


namespace ToDoConsoleApp.Datas
{
    internal class Card
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public int PersonID { get; set; }
        public int BoardID { get; set; }
        public int Size { get; set; }


        public Card(int personID,int boardID, string title, string content, int size)
        {
            PersonID = personID;
            BoardID = boardID;
            Title = title;
            Content = content;
            Size = size;
        }

        

    }

}

