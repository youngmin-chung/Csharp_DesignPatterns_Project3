/*
 * Program:         Assi3.exe
 * Module:          FormComponent.cs
 * Date:            August 5, 2019
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
        protected FormComponent _parent;

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
            if (_parent != null)
                return _parent.GetValue();
            return _value;
        }

        public void SetValue(string value)
        {
            if (_parent != null)
                _parent.SetValue(value);
            else
                _value = value;
        }

        public virtual bool IsValid()
        {
            return true;
        }
    }
}
