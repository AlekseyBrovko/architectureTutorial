using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

namespace CodeBase.Infrastructure
{
    public class GameStateMachine
    {
        //���������� �������
        private readonly Dictionary<Type, IState> _states;
        private IState _activeState;

        //����������� ������
        public GameStateMachine()
        {
            _states = new Dictionary<Type, IState>();
        }

        //��������
        public void Enter<TState>() where TState : IState
        {
                //? �������� �� null
            _activeState?.Exit();
            IState state = _states[typeof(TState)];
            state.Enter();
        }
    }
}
