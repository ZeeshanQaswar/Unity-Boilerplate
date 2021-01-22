using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Managers.Scripts
{
    public class LevelManager : MonoBehaviour
    {

        public static LevelManager Instance;

        private void Awake()
        {
            Instance = this;
        }

        private void OnEnable()
        {
            GameActions.LevelComplete += GameCompleteReceiver;
            GameActions.LevelFail += GameFailReceiver;
        }

        public void Init()
        {

        }

        public void Tick(float delta)
        {

        }

        // Run on Level Complete
        private void GameCompleteReceiver()
        {

        }

        // Run on Level Fail
        private void GameFailReceiver()
        {

        }

        private void OnDisable()
        {
            GameActions.LevelComplete -= GameCompleteReceiver;
            GameActions.LevelFail -= GameFailReceiver;
        }

    }
}