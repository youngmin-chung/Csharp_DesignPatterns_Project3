/*
 * Program:         Assi3.exe
 * Module:          Program.cs
 * Date:            August 19, 2019
 * Author:          Youngmin Chung
 * Requirement:     To properly program the State, you will need a second "Main" class outside your main method. 
 *                  Your main method should create a Main class and call a function on it; nothing else.
 * Description:     To properly program the State, you will need a second "Main" class outside your main method. 
 *                  Your main method should create a Main class and call a function on it; nothing else.      
 */

using Assi3.Classes;
using Assi3.Validators;

namespace Assi3
{
    /* 
     * As Context, StateContext class defines an interface of interest to clients
     * Maintains an instance of a ConcreteState subclass that defines the current state
     */
    class StateContext {
        private Form form;
        private IState _state;

        public void Run(Form form) {
            this.form = form;
            SetState(new InputState(this));
        }

        public void SetState(IState state)
        {
            _state = state;
            _state.Run();
        }

        public Form GetForm() {
            return form;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Form form = new Form();

            //Create classes that let you execute the following code:

            form.AddComponent(
                new MinLengthValidator(
                    new TextBox("Username"), 6
                )
            );
            form.AddComponent(
                new CharacterValidator(
                    new CharacterValidator(
                        new TextBox("Email"), "@"
                    ), "."
                )
            );
            form.AddComponent(
                new MinLengthValidator(
                    new TextBox("Real Name"), 2
                )
            );

            FormComponent password = new CharacterValidator(
                new MinLengthValidator(
                    new TextBox("Password"), 8
                ), "!"
            );
            form.AddComponent(password);

            form.AddComponent(
                new ValueMatchValidator(
                    new TextBox("Confirm Password"), password
                )
            );
            form.AddComponent(
                new NumberValidator(
                    new TextBox("Age")
                )
            );

            new StateContext().Run(form);
        }
    }
}
