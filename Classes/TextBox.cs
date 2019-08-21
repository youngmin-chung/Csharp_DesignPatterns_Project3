/*
 * Program:         Assi3.exe
 * Module:          TextBox.cs
 * Date:            August 7, 2019
 * Author:          Youngmin Chung
 * Summary:         a simple class that inherits from FormComponent. 
 *                  Its name is set by the main method and its value is set by the InputState.
 * Description:     As ConcreteColleague, TextBox class do...
 *                  - we pass in the userInput     
 */

namespace Assi3.Classes
{
    class TextBox : FormComponent
    {
        public TextBox(string userInput) : base(userInput) {}
    }
}
