/*
 * Program:         Assi3.exe
 * Module:          InputState.cs
 * Date:            August 7, 2019
 * Author:          Youngmin Chung
 * Summary:         gets input from the user and sets the value of each form object (from its Context instance variable) to the input.
 *                  Once it gets all the input, it sets the state to the done state.
 * Requirement:     Implement the State pattern with two states - "Entering Form Inputs" and "Done Form".
 *                  Your state should process user input
 * Description:     As ConcreateState, each subclass implements a behavior associated with a state of the Context      
 */

using Assi3.States;
using System;

namespace Assi3
{
    class InputState : IState
    {
        private StateContext _context;
        string userInput1 = "", userInput2 = "", state;

        public InputState(StateContext context)
        {
            _context = context;
        }

        public void Run()
        {
            Console.WriteLine("Welcome to the Form. @2019 Copyright - Youngmin Chung");

            // You shouldn't need a while loop for overall user input 
            // (except in one or two small places, for example making sure a user input is valid).
            for (int i = 0; i < _context.GetForm().GetComponents().Count; i++)
            {
                Console.WriteLine(_context.GetForm().GetComponents()[i].GetName() + ":");
                Console.Write("> ");
                userInput1 = Console.ReadLine();
                _context.GetForm().GetComponents()[i].SetValue(userInput1);
                while (!_context.GetForm().GetComponents()[i].IsValid())
                {
                    Console.WriteLine("Invalid entry, try again:");
                    Console.Write("> ");
                    userInput2 = Console.ReadLine();
                    _context.GetForm().GetComponents()[i].SetValue(userInput2);
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
                _context.SetState(new DoneState(_context));
        }
    }
}
