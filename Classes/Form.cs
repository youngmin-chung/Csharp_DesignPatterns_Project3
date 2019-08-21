/*
 * Program:         Assi3.exe
 * Module:          Form.cs
 * Date:            August 7, 2019
 * Author:          Youngmin Chung
 * Summary:         maintains a list of form components. Also maintains a "print" method that just outputs the names and values
 *                  of each FormComponent
 * Requirement:     Your Form should act as a mediator for its FormComponent colleagues. 
 *                  Because there is no interaction between FormComponent elements, 
 *                  the Mediator/Form will basically just be a list of FormComponents.
 * Description:     As Mediator, Form class defines an interface for communicating with Colleague objects     
 */

using Assi3.Classes;
using System.Collections.Generic;

namespace Assi3
{
    class Form
    {
        private List<FormComponent> _components;

        public Form()
        {
            _components = new List<FormComponent>();
        }

        public void AddComponent(FormComponent component)
        {
            _components.Add(component);
        }

        public List<FormComponent> GetComponents()
        {
            return _components;
        }

        public string Print()
        {
            string print = "";
            for (int i = 0; i < _components.Count; i++)
            {
                print = print + _components[i].GetName() + ": " + _components[i].GetName() + "\n";
            }
            return print;
        }
    }
}
