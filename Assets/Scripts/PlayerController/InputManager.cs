using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PlayerController.Scripts
{
    public class InputManager : MonoBehaviour
    {

        #region FIELDS DECLERATION

        float _inputX;
        float _inputY;

        StateManager _playerManager;
        CameraManager _camManager;

        float _delta;

        #endregion

        void Start()
        {
            TryGetComponent<StateManager>(out _playerManager);
            _playerManager.Init();

            TryGetComponent<CameraManager>(out _camManager);
            _camManager.Init(transform);
        }

        void Update()
        {
            _delta = Time.deltaTime;
            _playerManager.Tick(_delta);
        }

        private void LateUpdate()
        {
            _delta = Time.deltaTime;
            _camManager.Tick(_delta);
        }

    }
}
