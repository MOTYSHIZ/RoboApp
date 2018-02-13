using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MazeCell : MonoBehaviour {

    public IntVector2 coordinates;
  
    //Here we will creat a way get edge method so that we can boud them to our quad
    private MazeCellEdge[] edges = new MazeCellEdge[MazeDirections.Count];

    public MazeCellEdge GetEdge (MazeDirection direciont)
    {
        return edges[(int)direciont];

    }

    public void SetEdge (MazeDirection direction, MazeCellEdge edge)
    {
        edges[(int)direction] = edge;
    }

}
