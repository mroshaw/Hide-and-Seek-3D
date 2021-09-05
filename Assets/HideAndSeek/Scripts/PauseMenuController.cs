using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenuController : MonoBehaviour {
    
    [Header("Options Panel")]
    public GameObject PauseOptionsCanvas;

    public bool isPaused;
    // Use this for initialization
    void Start ()
    {
        isPaused = false;
    }
    
    void Update()
    {
        //uses the pause button to pause and unpause the game
        if(Input.GetKeyDown(KeyCode.P))
        {
            if(isPaused)
            {
                Continue();
            } 
            else
            {
                Pause();
            }
        }
    }
    
    public void Quit()
    {
        
        Application.Quit();
    }

    public void OnClickQuit()
    {
        Debug.Log("Quit pressed");
        Quit();
    }

    public void OnClickContinue()
    {
        Debug.Log("Continue pressed");
        Continue();
    }
    
    public void Pause()
    {
        isPaused = true;
        PauseOptionsCanvas.SetActive(true);
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        Time.timeScale = 0;
        
    }
    public void Continue()
    {
        
        isPaused = false;
        PauseOptionsCanvas.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        Time.timeScale = 1;
    }
    
    public void playHoverClip()
    {
       
    }

    void playClickSound()
    {

    }
}
