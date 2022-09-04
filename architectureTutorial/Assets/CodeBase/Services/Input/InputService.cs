using UnityEngine;

namespace CodeBase.Services.Input
{
    //абстрактный класс
    public abstract class InputService : IInputService
    {
        protected const string Horizontal = "Horizontal";
        protected const string Vertical = "Vertical";
        private const string Button = "Fire";

        //свойство тоже абстрактное
        public abstract Vector2 Axis { get; }
        public bool IsAttackButtonUp() => SimpleInput.GetButtonUp(Button);

        //берем из джойстика
        protected static Vector2 SimpleInputAxis() => 
            new Vector2(SimpleInput.GetAxis(Horizontal), SimpleInput.GetAxis(Vertical));
    }
}