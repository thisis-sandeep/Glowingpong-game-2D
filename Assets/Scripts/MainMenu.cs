using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject playButton;
    public GameObject quitButton;
    public GameObject helpButton;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Play()
    {
       
        SceneManager.LoadScene("PVP Game");
    }

    public void help()
    {
        SceneManager.LoadScene("Help Menu");
    }

    public void Back()
    {
        playButton.SetActive(true);
        quitButton.SetActive(true);
        helpButton.SetActive(true);
        
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
