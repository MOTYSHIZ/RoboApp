using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimedMovement : MonoBehaviour
{
    LinkedList<int> commandLinkedList = new LinkedList<int>();
    public CommandQVisual commandQVisual;
    public InputField inputField;

    Rigidbody rb;
    public float speed = 50;

    float lastTime = 0f;
    float inputTime = 0f;

	// Use this for initialization
	void Start ()
    {
        rb = GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	void Update ()
    {
        if(Time.time > lastTime + inputTime)
        {

        }
    }

    IEnumerator moveForward()
    {
        while(true)
        {
            int inputTime = 0;
            System.Int32.TryParse(inputField.text, out inputTime);

            yield return new WaitForEndOfFrame();
        }
    }

    public void moveBackward()
    {
        rb.AddRelativeForce(Vector3.back * speed, ForceMode.Force);
    }

    public void turnRight()
    {
        rb.AddRelativeTorque(0, 10, 0, ForceMode.Force);
    }

    public void turnLeft()
    {
        rb.AddRelativeTorque(0,-10, 0,ForceMode.Force);
        
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
        while (commandLinkedList.Count > 0)
        {
            int currentCommand = commandLinkedList.First.Value;
            commandLinkedList.RemoveFirst();
            commandQVisual.removeFirstIconVisual();

            if (currentCommand == 0)
            {
                StartCoroutine(moveForward());
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
