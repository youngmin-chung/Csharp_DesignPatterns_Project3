/*
 * Program:         Assi3.exe
 * Module:          CharacterValidator.cs
 * Date:            August 19, 2019
 * Author:          Youngmin Chung
 * Requirement:     Your FormComponents should have Validator decorators. Each decorator is meant to change the form input's 
 *                  validation - for example, a MinLengthDecorator orHasCharacterDecorator, etc. would be good ideas.
 * Description:     As ConcreteColleague, CharacterValidator class do...
 *                  And here in the Constructor we pass in the name, 
 *                  and right below that we have the IsValid(), which valids out GetValue() contains string or not,
 */

using Assi3.Classes;

namespace Assi3
{
    class CharacterValidator : FormComponent
    {
        private string _character;

        public CharacterValidator(FormComponent component, string character) : base(component.GetName())
        {
            _character = character.ToLower();
            _component = component;
        }

        public override bool IsValid()
        {
            if (!GetValue().ToLower().Contains(_character))
                return false;
            return _component.IsValid();
        }

    }
}
