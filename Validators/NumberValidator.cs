/*
 * Program:         Assi3.exe
 * Module:          NumberValidator.cs
 * Date:            August 7, 2019
 * Author:          Youngmin Chung
 * Summary:         there are the decorator classes. They inherit from FormComponent and their ConcreateComponent is TextBox
 * Requirement:     Your FormComponents should have Validator decorators. Each decorator is meant to change the form input's 
 *                  validation - for example, a MinLengthDecorator or HasCharacterDecorator, etc. would be good ideas. 
 * Description:     As Decorator, NumberValidator class do...
 *                  And here in the Constructor we pass in the name, 
 *                  and right below that we have the IsValid(), which valids out GetValue() contains numeric value or not           
 */

using Assi3.Classes;

namespace Assi3.Validators
{
    class NumberValidator : FormComponent
    {
        public NumberValidator(FormComponent component) : base(component.GetName())
        {
            _component = component;
        }

        public override bool IsValid()
        {
            int result;
            if (!int.TryParse(GetValue(), out result))
                return false;
            return _component.IsValid();
        }
    }
}
