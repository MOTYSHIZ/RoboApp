using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class main_menu : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	public void startGame()                                                 //Runs level 1
    {
        SceneManager.LoadScene("Level01", LoadSceneMode.Single);            //Load Level one
    }

    public void timedMovement()                                                 //Runs level 1
    {
        SceneManager.LoadScene("TimedMovement", LoadSceneMode.Single);            //Load Level one
    }

    public void Restartscean()                                              //Reloads level
    {
        SceneManager.LoadScene(Application.loadedLevel);                    //load Restart
    }

    public void GameMode()                                                  //brings you to Game Mode
    {
        SceneManager.LoadScene("GameMode", LoadSceneMode.Single);           //Load Game Mode
    }

    public void ChallMenu()                                                 //brings user to Challenge Menu
    {
        SceneManager.LoadScene("Challenge", LoadSceneMode.Single);          //Loads Challenge Menu
    }

    public void GoBack()                                                    // Able to return to menu
    {
        SceneManager.LoadScene("Main Menu", LoadSceneMode.Single);          //Bring you to the Main Menu
    }

    public  void StoryMode()
    {
        SceneManager.LoadScene("Story", LoadSceneMode.Single);
    }

}

  