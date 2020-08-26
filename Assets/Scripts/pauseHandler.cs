using UnityEngine;

public class pauseHandler : StateHandler
{
    //im Pause State wird das Spiel pausiert
    public override void OnEnter()
    {
        Time.timeScale = 0;
    }

    //beim verlassen des Pause States wird das Spiel fortgesetzt
    public override void OnExit()
    {
        Time.timeScale = 1;
    }
}
