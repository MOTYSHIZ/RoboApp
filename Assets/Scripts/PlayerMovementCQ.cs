using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementCQ : PlayerMovement
{
    LinkedList<int> commandLinkedList = new LinkedList<int>();
    public CommandQVisual commandQVisual;

    // Use this for initialization
    void Start ()
    {
        
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            moveForward();
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            turnLeft();
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            moveBackward();
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            turnRight();
        }
    }
    
    public void queueMove(int commandType)
    {
        commandLinkedList.AddLast(new LinkedListNode<int>(commandType));
        commandQVisual.addIconVisual(commandType);
    }

    public void runCommand()
    {
        StartCoroutine("RunCommandList");
    }

    IEnumerator RunCommandList()
    {
        while(commandLinkedList.Count > 0)
        {
            int currentCommand = commandLinkedList.First.Value;
            commandLinkedList.RemoveFirst();
            commandQVisual.removeFirstIconVisual();

            if (currentCommand == 0)
            {
                moveForward();
            }
            if (currentCommand == 1)
            {
                moveBackward();
            }
            if (currentCommand == 2)
            {
                turnLeft();
            }
            if (currentCommand == 3)
            {
                turnRight();
            }

            yield return new WaitForSeconds(.5f);
        }
    }
}
