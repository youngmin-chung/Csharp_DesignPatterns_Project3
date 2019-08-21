/*
 * Program:         Assi3.exe
 * Module:          DoneState.cs
 * Date:            August 7, 2019
 * Author:          Youngmin Chung
 * Summary:         calls its Context instance variable's Form variable's print method, when the user enters "print".
 * Requirement:     Implement the State pattern with two states - "Entering Form Inputs" and "Done Form".
 *                  When the form is Done, user can type 'print' to neatly print the form, and 'exit' to quit.
 * Description:     As ConcreateState, each subclass implements a behavior associated with a state of the Context      
 */

using System;

namespace Assi3.States
{
    class DoneState : IState
    {
        private StateContext _context;
        string state = "";

        public DoneState(StateContext context)
        {
            _context = context;
        }

        public void Run()
        {
            Console.WriteLine("\nType print to print the form, or exit to leave.\n");
            state = "";
            while (state != "exit")
            {
                Console.Write("> ");
                state = Console.ReadLine();
                if (state == "print")
                    Console.WriteLine(_context.GetForm().Print());
            }
        }
    }
}
