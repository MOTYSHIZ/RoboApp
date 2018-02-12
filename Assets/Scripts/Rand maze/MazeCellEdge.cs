using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {

    public MazeCell cell, otherCell;
    public MazeDirection Direction;

    //this code will set the location of the children quads to know where the wall will go.
    public void Initialize (MazeCell cell, MazeCell otherCell, MazeDirection)
    {
        this.cell = cell;
        this.otherCell = otherCell;
        this.direction = direction;
        cell.SetEdge(Direction, this);
        transform.parent = cell.transform;
        transform.localPosition = Vector3.zero;
    }
}
