using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{
    public Text goText;
    public GameObject replayButton;
    public GameObject mainMenuButton;
    // Start is called before the first frame update
    void Start()
    {
        if(ScoreManagerPVP.winnerCheck == 1)
        {
            goText.text = "Player 1 wins!";
        }
        else if(ScoreManagerPVP.winnerCheck == 2)
        {
            goText.text = "Player 2 wins!";
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ReaplayGame()
    {
        if(ScoreManagerPVP.winnerCheck == 1 || ScoreManagerPVP.winnerCheck == 2)
        {
            SceneManager.LoadScene("PVP Game");
        } 
    }

    public void GoToMainMenu()
    {
        ScoreManagerPVP.winnerCheck = -1;
        SceneManager.LoadScene("Main Menu");
    }
}
