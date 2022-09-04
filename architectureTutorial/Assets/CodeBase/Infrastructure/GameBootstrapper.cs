using UnityEngine;

namespace CodeBase.Infrastructure
{
    public class GameBootstrapper : MonoBehaviour, ICoroutineRunner
    {
        private Game _game;

        private void Awake()
        {
            //точка входа в игру
            _game = new Game();
            _game._stateMachine.Enter<BootstrapState>();

            DontDestroyOnLoad(this);
        }
    }

}