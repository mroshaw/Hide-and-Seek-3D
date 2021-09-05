using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
	public PauseMenuController pauseMenuController;
    // Start is called before the first frame update
    void Start()
    {
	    Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        //uses the Esc button to pause and unpause the game
		if(Input.GetKeyDown(KeyCode.Escape))
		{
			if(pauseMenuController.isPaused)
			{
				pauseMenuController.Continue();
			} 
			else
			{
				pauseMenuController.Pause();
			}
		}
    }
    
}
