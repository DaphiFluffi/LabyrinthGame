
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ReplayButton : MonoBehaviour
{
        // wenn man auf dem Replay Button drückt, wie das Spiel von neuem gestartet
        public Button replayButton;

        void Start () {
            Button btn = replayButton.GetComponent<Button>();
            btn.onClick.AddListener(TaskOnClick);
        }

        void TaskOnClick(){
            SceneManager.LoadScene("Scenes/MainGameScene");
        }
    }

