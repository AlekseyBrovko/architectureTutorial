using UnityEngine;

namespace CodeBase.Services.Input
{
    //реализация inputService
    public class StandaloneInputService : InputService
    {
        //реализация vector2 
        public override Vector2 Axis
        {
            get
            {   //мы берем с симпл инпут, если там ввода нет, то берем с клавиатуры
                Vector2 axis = SimpleInputAxis();
                if (axis == Vector2.zero)
                {
                    axis = UnityAxis();
                }
                return axis;
            }
        }

        private static Vector2 UnityAxis() => 
            new Vector2(UnityEngine.Input.GetAxis(Horizontal), UnityEngine.Input.GetAxis(Vertical));
    }
}