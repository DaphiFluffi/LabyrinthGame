using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Highscore : MonoBehaviour
{
    //der HighScore und der Score werden in zwei UI-TextMeshPro Objekten angezeigen
    [SerializeField] private TextMeshProUGUI scoreText;
    [SerializeField] private TextMeshProUGUI highScore;
    private WinScript winScript;
   
    private PillSpawner pillSpawnerScript;
    private int score = 0;
    
    private void Start()
    {
        highScore.text = "HighScore: " + PlayerPrefs.GetInt("HighScore", 0); // 0 als default Wert
    }
    
    private void FixedUpdate()
    {
        winScript =  FindObjectOfType<WinScript>();
        pillSpawnerScript = FindObjectOfType<PillSpawner>();
        CalculateScore();
 
        if (Input.GetKey(KeyCode.Q))
        {
            ResetHighScore();
        }
    }

    private void CalculateScore()
    {
        if (pillSpawnerScript.GetPillAmount() > 0 )
        {
            //die Menge an Pillen entspricht dem Score
            score = pillSpawnerScript.GetPillAmount();
            //wenn man das Ziel erreicht bekommt man den letzen möglichen Punkt
            if (winScript.GetWin()){
                score += 1;
            }
        }
        
        scoreText.text = "Score: " + score;
        if (score > PlayerPrefs.GetInt("HighScore", 0))
        {
            PlayerPrefs.SetInt("HighScore", score);
            highScore.text = "HighScore: " + score;
        }
    }

    // wenn man auf Q drückt, kann man seinen Highscore resetten 
   private void ResetHighScore()
    {
        PlayerPrefs.DeleteKey("HighScore");
        highScore.text = "HighScore: 0";
    }

}
