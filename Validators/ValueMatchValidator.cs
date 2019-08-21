/*
 * Program:         Assi3.exe
 * Module:          ValueMatchValidator.cs
 * Date:            August 7, 2019
 * Author:          Youngmin Chung
 * Summary:         there are the decorator classes. They inherit from FormComponent and their ConcreateComponent is TextBox
 * Requirement:     Your FormComponents should have Validator decorators. Each decorator is meant to change the form input's 
 *                  validation - for example, a MinLengthDecorator or HasCharacterDecorator, etc. would be good ideas.
 * Description:     As Decorator, ValueMatchValidator class do...
 *                  And here in the Constructor we pass in the name, 
 *                  and right below that we have the IsValid(), which valids out GetValue() contains matched values or not,            
 */

using Assi3.Classes;

namespace Assi3.Validators
{
    class ValueMatchValidator : FormComponent
    {
        private FormComponent _other;

        public ValueMatchValidator(FormComponent component, FormComponent other) : base(component.GetName())
        {
            _component = component;
            _other = other;
        }

        public override bool IsValid()
        {
            if (GetValue() != _other.GetValue())
                return false;
            return _component.IsValid();
        }
    }
}
