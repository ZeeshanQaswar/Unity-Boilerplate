using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PlayerController.Scripts
{
    public class StateManager : MonoBehaviour
    {
        float _horizontal;
        float _vertical;
        float _movInput;
        Vector3 _movDirection;

        private void OnEnable()
        {
            GameActions.LevelComplete += GameCompleteReceiver;
            GameActions.LevelFail += GameFailReceiver;
        }

        public void Init()
        {

        }

        public void Tick( float delta )
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
