
using System;

namespace ToDoConsoleApp.Operations
{

    interface IOperation
    {
        void addNewCards() { }
        void deleteCards() { }
        void carryCards() { }
        void updateCards() { }
        void listCards() { }

    }

}