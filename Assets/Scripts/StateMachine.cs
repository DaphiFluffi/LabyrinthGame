using UnityEngine;

   public class StateMachine : MonoBehaviour {
        [SerializeField] private State currentState;

        private State idleState, playState, pauseState, looseConditionState, winConditionState;

        [SerializeField] private StateHandler idleHandler,
            playHandler,
            pauseHandler,
            loseConditionHandler,
            winConditionHandler;

        private void Start() {
            
            idleState = new State("Idle", idleHandler);
            playState = new State("Play", playHandler);
            pauseState = new State("Pause", pauseHandler);
            looseConditionState = new State("Lose", loseConditionHandler);
            winConditionState = new State("Win", winConditionHandler);
            
            currentState = idleState;
            
        }
        
        private bool Handle(Event transition) {
            switch (transition) {
                case Event.WASDClicked:
                    return Transition(idleState, playState);
                case Event.SpaceClicked:
                    if (Transition(playState, pauseState))
                    {
                        return true;
                    }else if (Transition(pauseState, playState))
                    {
                        return true;
                    }
                    return false;
                case Event.GoalReached:
                    return Transition(playState, winConditionState);
                case Event.FellTroughHole:
                    return Transition(playState, looseConditionState);
                
            }

            return false;
        }

        private bool Transition(State expectedState, State nextState) {
            if (currentState == expectedState) {
                currentState.onExit?.Invoke();
                Debug.Log($"[{currentState.stateName}] -> [{nextState.stateName}]");
                currentState = nextState;
                nextState.onEnter?.Invoke();
                Debug.Log("nextState.onEnter?.Invoke();");
                return true;
            }

            return false;
        }
        
        public bool Trigger(Event @event) {
            return Handle(@event);
        }
    }
