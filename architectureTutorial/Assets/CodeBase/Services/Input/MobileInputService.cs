using UnityEngine;

namespace CodeBase.Services.Input
{
    //унаследовались 
    public class MobileInputService : InputService
    {
        //перезаписали переменную
        public override Vector2 Axis => SimpleInputAxis();
    }
}