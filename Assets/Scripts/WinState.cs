using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class WinState : MonoBehaviour
{

    public Button buttonRestart;
    public Button buttonNextLvl;
    public Text WinText;
    //private bool levelComplete;

    // Use this for initialization
    void Start()
    {
        //levelComplete = false;
        WinText.text = "";
        buttonRestart.gameObject.SetActive(false);
        buttonNextLvl.gameObject.SetActive(false);
    }



    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            WinText.text = "Level Complete!";
            if (buttonRestart != null) { buttonRestart.gameObject.SetActive(true); }
            if (buttonNextLvl != null) { buttonNextLvl.gameObject.SetActive(true); }


            //levelComplete = true;
            //buttonRestart.interactable = true;
            //buttonNextLvl.interactable = true;
        }
    }

    public void NextLevel()
    {
        SceneManager.LoadScene("Level02", LoadSceneMode.Single);
    }
}
