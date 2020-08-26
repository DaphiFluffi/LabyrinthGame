using System;
using UnityEngine;


    public abstract class StateHandler : MonoBehaviour, IStateHandler
    {
        public abstract void OnEnter();

        public abstract void OnExit();
    }
