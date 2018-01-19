using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimedMovement : MonoBehaviour
{
    LinkedList<Vector2> commandLinkedList = new LinkedList<Vector2>();
    public CommandQVisual commandQVisual;
    public InputField inputField;
    public Dropdown dropDown;

    Rigidbody rb;
    public float speed = 50;

	// Use this for initialization
	void Start ()
    {
        rb = GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	void Update ()
    {
    }

    IEnumerator moveForward(float inputTime)
    {
        float lastTime = Time.time;

        while(Time.time < lastTime + inputTime)
        {
            if(rb.velocity.sqrMagnitude < 400) rb.AddRelativeForce(Vector3.forward * speed, ForceMode.Force);
            yield return new WaitForEndOfFrame();
        }
    }

    IEnumerator moveBackward(float inputTime)
    {
        float lastTime = Time.time;

        while (Time.time < lastTime + inputTime)
        {
            if (rb.velocity.sqrMagnitude < 400) rb.AddRelativeForce(Vector3.back * speed, ForceMode.Force);
            yield return new WaitForEndOfFrame();
        }
    }

    IEnumerator turnRight(float inputTime)
    {
        float lastTime = Time.time;

        while (Time.time < lastTime + inputTime)
        {
            if (rb.angularVelocity.sqrMagnitude < 20) rb.AddRelativeTorque(0, 10, 0, ForceMode.Force); ;
            yield return new WaitForEndOfFrame();
        }
    }

    IEnumerator turnLeft(float inputTime)
    {
        float lastTime = Time.time;

        while (Time.time < lastTime + inputTime)
        {
            if (rb.angularVelocity.sqrMagnitude < 20) rb.AddRelativeTorque(0, -10, 0, ForceMode.Force);
            yield return new WaitForEndOfFrame();
        }
    }

    public void queueMove()
    {
        int commandType = dropDown.value;
        float inputTime = 0;
        float.TryParse(inputField.text, out inputTime);

        commandLinkedList.AddLast(new Vector2(dropDown.value, inputTime));
        commandQVisual.addIconVisual(commandType);
        Debug.Log(inputTime);
    }

    public void runCommand()
    {
        StartCoroutine("RunCommandList");
    }

    IEnumerator RunCommandList()
    {
        while (commandLinkedList.Count > 0)
        {
            int currentCommand = (int)commandLinkedList.First.Value.x;
            float inputTime = commandLinkedList.First.Value.y;
            commandLinkedList.RemoveFirst();
            commandQVisual.removeFirstIconVisual();

            if (currentCommand == 0)
            {
                StartCoroutine(moveForward(inputTime));
            }
            if (currentCommand == 1)
            {
                StartCoroutine(moveBackward(inputTime));
            }
            if (currentCommand == 2)
            {
                StartCoroutine(turnLeft(inputTime));
            }
            if (currentCommand == 3)
            {
                StartCoroutine(turnRight(inputTime));
            }

            yield return new WaitForSeconds(inputTime);
        }
    }
}
