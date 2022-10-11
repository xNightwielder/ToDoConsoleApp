using System;

namespace ToDoConsoleApp.Datas
{
    internal class TeamPerson
    {
        public int PersonID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public TeamPerson(int personID, string name, string surname)
        {
            PersonID = personID;
            Name = name;
            Surname = surname;
        }
    }
}