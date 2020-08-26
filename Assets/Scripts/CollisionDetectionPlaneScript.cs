using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionDetectionPlaneScript : MonoBehaviour
{
    
    private StateMachine st;

    private void Start()
    {
        st = FindObjectOfType<StateMachine>();
        
    }
    
    //wenn die Plane vom Ball getroffen wird, hat der Spieler verloren und das Spiel wird neu gestartet
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag($"Ball"))
        {
            st.Trigger(Event.FellTroughHole);
          
        }
    }
    
}
