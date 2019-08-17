/*
 * Program:         Assi3.exe
 * Module:          NumberValidator.cs
 * Date:            August 5, 2019
 * Author:          Youngmin Chung
 * Description:     As ConcreteColleague, NumberValidator class do...
 *                  And here in the Constructor we pass in the name, 
 *                  and right below that we have the IsValid(), which valids out GetValue() contains numeric value or not           
 */

using Assi3.Classes;

namespace Assi3.Validators
{
    class NumberValidator : FormComponent
    {
        public NumberValidator(FormComponent parent) : base(parent.GetName())
        {
            _parent = parent;
        }

        public override bool IsValid()
        {
            int result;
            if (!int.TryParse(GetValue(), out result))
                return false;
            return _parent.IsValid();
        }
    }
}
