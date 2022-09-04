using UnityEngine;

namespace CodeBase.Services.Input
{
    //���������� inputService
    public class StandaloneInputService : InputService
    {
        //���������� vector2 
        public override Vector2 Axis
        {
            get
            {   //�� ����� � ����� �����, ���� ��� ����� ���, �� ����� � ����������
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