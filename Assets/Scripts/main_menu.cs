using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class main_menu : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	public void startGame()
    {
        SceneManager.LoadScene("Level01", LoadSceneMode.Single);   //load main scean 
    }

    public void Restartscean()
    {
        SceneManager.LoadScene(Application.loadedLevel);
    }

    public void GameMode()
    {
        SceneManager.LoadScene("GameMode", LoadSceneMode.Single);
    }

    public void StoryMenu()
    {
        SceneManager.LoadScene("Story", LoadSceneMode.Single);
    }

    public void ChallMenu()
    {
        SceneManager.LoadScene("Challenge", LoadSceneMode.Single);
    }
}

  