using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class MazeCellEdge : MonoBehaviour {

    public MazeCell cell, otherCell;
    public MazeDirection direction;

    //this code will set the location of the children quads to know where the wall will go.
    public virtual void Initialize(MazeCell cell, MazeCell otherCell, MazeDirection direction)
    {
        this.cell = cell;
        this.otherCell = otherCell;
        this.direction = direction;
        cell.SetEdge(direction, this);
        transform.parent = cell.transform;
        transform.localPosition = Vector3.zero;
        transform.localRotation = direction.ToRotation();
    }

    //help with player to open doors
    public virtual void OnPlayerEntered() { }
    public virtual void OnPlayerExited() { }

}
