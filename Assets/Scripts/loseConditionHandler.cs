using UnityEngine;
using UnityEngine.SceneManagement;

public class loseConditionHandler : StateHandler
 {
     public override void OnEnter()
     {
         Debug.Log("this was called at all");
         SceneManager.LoadScene("Scenes/MainGameScene");
     }
 
     public override void OnExit()
     {
         Debug.Log("Lost");        
     }
 }

