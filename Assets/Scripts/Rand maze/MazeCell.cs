using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MazeCell : MonoBehaviour {

    public IntVector2 coordinates;
    public IntVector2 size;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    //Here we will creat a way get edge method so that we can boud them to our quad
    private MazeCellEdge[] edges = new MazeCellEdge[MazeDirection.Count];

    public MazeCellEdge (MazeDirection direciont)
    {
        return edges[(int)direciont];

    }

    public void SetEdge (MazeDirection direction, MazeCell edge)
    {
        edges[(int)direction] = edge;
    }

}
