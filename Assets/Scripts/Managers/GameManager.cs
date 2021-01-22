using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Managers.Scripts
{
    public class GameManager : MonoBehaviour
    {

        #region FIELDS DECLERATION

        LevelManager _levelManager;
        UIManager _uIManager;

        float _delta;

        #endregion

        void Start()
        {
            _levelManager = LevelManager.Instance;
            _levelManager.Init();

            _uIManager = UIManager.Instance;
            _uIManager.Init();
        }

        void Update()
        {
            _delta = Time.deltaTime;

            _levelManager.Tick(_delta);
            _uIManager.Tick(_delta);
        }

    }
}
