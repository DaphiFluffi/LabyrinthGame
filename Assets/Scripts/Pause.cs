using UnityEngine;

    public class Pause : MonoBehaviour
    {
        private StateMachine st;

        private void Start()
        {
            st = FindObjectOfType<StateMachine>();
        
        }
    
        void Update()
        {
            // mit der Leertaste kann das Spiel pausiert und fortgesetzt werden 
            if (Input.GetKeyDown(KeyCode.Space))
            {
                //dabei geht das Spiel aus dem Play State in den Pause State über
                st.Trigger(Event.SpaceClicked);
            }
        }
    }
