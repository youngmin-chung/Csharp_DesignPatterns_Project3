/*
 * Program:         Assi3.exe
 * Module:          IState.cs
 * Date:            August 5, 2019
 * Author:          Youngmin Chung
 * Description:     Defines an interface for encapsulating the behavior associated with a particular state of the Context      
 */

namespace Assi3 {
    public interface IState
    {
        void Run(); // called on creation
    }
}
