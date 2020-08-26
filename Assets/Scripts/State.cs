using System;


    [Serializable]
    public class State {
        public string stateName;
        public Action onEnter;
        public Action onExit;

        public State(string name, StateHandler handler) {
            stateName = name;
            if (handler != null) {
                onEnter += handler.OnEnter;
                onExit += handler.OnExit;
            }
        }
    }
