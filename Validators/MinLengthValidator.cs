/*
 * Program:         Assi3.exe
 * Module:          MinLengthValidator.cs
 * Date:            August 5, 2019
 * Author:          Youngmin Chung
 * Description:     As ConcreteColleague, MinLengthValidator class do...
 *                  And here in the Constructor we pass in the name, 
 *                  and right below that we have the IsValid(), which valids out GetValue() contains int value as minLength or not           
 */

using Assi3.Classes;

namespace Assi3.Validators
{
    class MinLengthValidator : FormComponent
    {
        private int _minLength;

        public MinLengthValidator(FormComponent parent, int minLength): base(parent.GetName())
        {
            _minLength = minLength;
            _parent = parent;
        }

        public override bool IsValid()
        {
            if (GetValue().Length < _minLength)
                return false;
            return _parent.IsValid();
        }
    }
}
