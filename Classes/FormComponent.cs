/*
 * Program:         Assi3.exe
 * Module:          FormComponent.cs
 * Date:            August 19, 2019
 * Author:          Youngmin Chung
 * Description:     As AbstractColleague, FormComponent class...      
 *                  And here, we define a few variables, and the name. 
 *                  Then we assign the name to a private variable and the Constructor, 
 *                  and then we assign a getter for the participant name, and right below that, 
 *                  following that are two methods, GetValue() and SetValue().
 */

namespace Assi3.Classes
{
    class FormComponent
    {
        protected string _name;
        protected string _value;
        protected FormComponent _component;

        public FormComponent(string name)
        {
            _name = name;
            _value = "";
        }

        public string GetName()
        {
            return _name;
        }

        public string GetValue()
        {
            if (_component != null)
                return _component.GetValue();
            return _value;
        }

        public void SetValue(string value)
        {
            if (_component != null)
                _component.SetValue(value);
            else
                _value = value;
        }

        public virtual bool IsValid()
        {
            return true;
        }
    }
}
