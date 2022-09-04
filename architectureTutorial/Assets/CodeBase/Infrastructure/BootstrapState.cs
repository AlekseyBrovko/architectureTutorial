using CodeBase.Services.Input;
using System;
using UnityEngine;

namespace CodeBase.Infrastructure
{
    public class BootstrapState : IState
    {
        private readonly GameStateMachine _stateMachine;
        public BootstrapState(GameStateMachine gameStateMachine)
        {
            _stateMachine = gameStateMachine;
        }

        public GameStateMachine GameStateMachine { get; }

        public void Enter()
        {
            RegisterServices();
        }

        private void RegisterServices()
        {
            Game.InputService = RegisterInputService();
        }

        public void Exit()
        {
            
        }

        private static IInputService RegisterInputService()
        {
            if (Application.isEditor)
                return new StandaloneInputService();
            else
                return new MobileInputService();
        }
    }
}
