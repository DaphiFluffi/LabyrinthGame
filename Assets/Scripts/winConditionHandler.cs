using UnityEngine;
using UnityEngine.SceneManagement;


public class winConditionHandler : StateHandler
{
    private bool isTriggered = false;
    public override void OnEnter()
    {
        SceneManager.LoadScene("Scenes/EndScene");
        isTriggered = true;
        if (isTriggered)
        {
            //sobald der Ball ein Mal das Ziel berührt hat, hat er bereits gewonnen
            // würde der Trigger weiter anbleiben, könnte man mehrmals gewinnen
            GetComponent<Collider>().isTrigger = false; 
        }
    }

    public override void OnExit()
    {
        Debug.Log("Win!");
    }
}
