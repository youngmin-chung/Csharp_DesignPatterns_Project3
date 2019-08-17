/*
 * Program:         Assi3.exe
 * Module:          CharacterValidator.cs
 * Date:            August 5, 2019
 * Author:          Youngmin Chung
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

        public CharacterValidator(FormComponent parent, string character) : base(parent.GetName())
        {
            _character = character.ToLower();
            _parent = parent;
        }

        public override bool IsValid()
        {
            if (!GetValue().ToLower().Contains(_character))
                return false;
            return _parent.IsValid();
        }

    }
}
