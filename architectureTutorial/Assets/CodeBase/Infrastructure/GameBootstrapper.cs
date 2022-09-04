using System;
using UnityEngine;

namespace CodeBase.Infrastructure
{
    public class GameBootstrapper : MonoBehaviour
    {
        private Game _game;

        private void Awake()
        {
            //точка входа в игру
            _game = new Game();

            DontDestroyOnLoad(this);
        }
    }
}