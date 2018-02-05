using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManage : MonoBehaviour {

    private void Start()
    {
        BeginGame();                                // start game
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))      //when the space bare is pressed then the game Restarts
        {
            RestartGame();
        }
    }

    public Maze mazePrefab;                 //prefab for the maze

    private Maze mazeInstance;              //

    private void BeginGame()                // when the maze starts there will be a randomly generated maze avaliable
    {
        mazeInstance = Instantiate(mazePrefab) as Maze;
        StartCoroutine(mazeInstance.Generate());

    }

    private void RestartGame()              // when the game restarts, it should destroy the last maze then go back to begingame
    {
        StopAllCoroutines();
        Destroy(mazeInstance.gameObject);
        BeginGame();
    }
}
