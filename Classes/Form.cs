/*
 * Program:         Assi3.exe
 * Module:          Form.cs
 * Date:            August 5, 2019
 * Author:          Youngmin Chung
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
            foreach (FormComponent component in _components)
                print = print + component.GetName() + ": " + component.GetValue() + "\n";
            return print;
        }
    }
}
