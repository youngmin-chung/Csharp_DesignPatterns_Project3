/*
 * Program:         Assi3.exe
 * Module:          MinLengthValidator.cs
 * Date:            August 19, 2019
 * Author:          Youngmin Chung
 * Requirement:     Your FormComponents should have Validator decorators. Each decorator is meant to change the form input's 
 *                  validation - for example, a MinLengthDecorator or HasCharacterDecorator, etc. would be good ideas.
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

        public MinLengthValidator(FormComponent component, int minLength): base(component.GetName())
        {
            _minLength = minLength;
            _component = component;
        }

        public override bool IsValid()
        {
            if (GetValue().Length < _minLength)
                return false;
            return _component.IsValid();
        }
    }
}
