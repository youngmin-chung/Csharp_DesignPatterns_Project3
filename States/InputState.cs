/*
 * Program:         Assi3.exe
 * Module:          InputState.cs
 * Date:            August 5, 2019
 * Author:          Youngmin Chung
 * Description:     As ConcreateState, each subclass implements a behavior associated with a state of the Context      
 */

using Assi3.Classes;
using Assi3.States;
using System;

namespace Assi3
{
    class InputState : IState
    {
        private StateContext _context;
        string userInput1 = "", userInput2 = "", state;

        public InputState(StateContext main)
        {
            _context = main;
        }

        public void Run()
        {
            Console.WriteLine("Welcome to the Form. @2019 Copyright - Youngmin Chung");
            foreach (FormComponent component in _context.GetForm().GetComponents())
            {
                Console.WriteLine(component.GetName() + ":");
                Console.Write("> ");
                userInput1 = Console.ReadLine();
                component.SetValue(userInput1);
                while (!component.IsValid())
                {
                    Console.WriteLine("Invalid entry, try again:");
                    Console.Write("> ");
                    userInput2 = Console.ReadLine();
                    component.SetValue(userInput2);
                }
            }
            Console.WriteLine("\nYou're done! To confirm, here's what you wrote:\n");
            Console.WriteLine(_context.GetForm().Print());
            Console.WriteLine("Type reset to reset, or ok to proceed");

            for (state = ""; state != "ok" && state != "reset"; state = Console.ReadLine().ToLower())
                Console.Write("> ");
            if (state == "reset")
                Run();
            else
                _context.SetState((IState)new DoneState(_context));
        }
    }
}
