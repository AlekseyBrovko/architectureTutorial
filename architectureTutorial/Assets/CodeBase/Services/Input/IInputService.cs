using UnityEngine;

namespace CodeBase.Services.Input
{
    //интерфейс
    public interface IInputService
    {
        Vector2 Axis { get; }

        bool IsAttackButtonUp();
    }
}