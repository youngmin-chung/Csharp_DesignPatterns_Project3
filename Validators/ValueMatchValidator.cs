/*
 * Program:         Assi3.exe
 * Module:          ValueMatchValidator.cs
 * Date:            August 5, 2019
 * Author:          Youngmin Chung
 * Description:     As ConcreteColleague, ValueMatchValidator class do...
 *                  And here in the Constructor we pass in the name, 
 *                  and right below that we have the IsValid(), which valids out GetValue() contains matched values or not,            
 */

using Assi3.Classes;

namespace Assi3.Validators
{
    class ValueMatchValidator : FormComponent
    {
        private FormComponent _other;

        public ValueMatchValidator(FormComponent parent, FormComponent other) : base(parent.GetName())
        {
            _parent = parent;
            _other = other;
        }

        public override bool IsValid()
        {
            if (GetValue() != _other.GetValue())
                return false;
            return _parent.IsValid();
        }
    }
}
