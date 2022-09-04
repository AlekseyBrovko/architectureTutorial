using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

namespace CodeBase.Infrastructure
{
    public class GameStateMachine
    {
        //объ€вление словар€
        private readonly Dictionary<Type, IState> _states;
        private IState _activeState;

        //конструктор класса
        public GameStateMachine()
        {
            _states = new Dictionary<Type, IState>();
        }

        //дженерик
        public void Enter<TState>() where TState : IState
        {
                //? проверка на null
            _activeState?.Exit();
            IState state = _states[typeof(TState)];
            state.Enter();
        }
    }
}
