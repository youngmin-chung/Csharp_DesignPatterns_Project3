/*
 * Program:         Assi3.exe
 * Module:          DoneState.cs
 * Date:            August 5, 2019
 * Author:          Youngmin Chung
 * Description:     As ConcreateState, each subclass implements a behavior associated with a state of the Context      
 */

using System;

namespace Assi3.States
{
    class DoneState : IState
    {
        private StateContext _context;
        string state = "";

        public DoneState(StateContext main)
        {
            _context = main;
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
