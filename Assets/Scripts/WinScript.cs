using UnityEngine;
using UnityEngine.SceneManagement;

public class WinScript : MonoBehaviour
{
    private bool won;
    private StateMachine st;

    private void Start()
    {
        st = FindObjectOfType<StateMachine>();
        
    }
    private void OnTriggerEnter(Collider other)
    {
        //wenn der Ball auf dem "ZielBoden" ankommt, gilt das Spiel als gewonnen
        if (other.CompareTag($"Ball"))
        {
            won = true;
            st.Trigger(Event.GoalReached);
        }
    }
    
    public bool GetWin()
    {
        return won;
    }
    
}
