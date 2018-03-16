using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MazeRoom : ScriptableObject
{

    public int settingsIndex;

    public MazeRoomSettings settings;

    private List<MazeCell> cells = new List<MazeCell>();

    public void Add(MazeCell cell)
    {
        cell.room = this;
        cells.Add(cell);
    }

    public void Assimilate (MazeRoom room)
    {
        for(int i = 0; i < room.cells.Count; i++)
        {
            Add(room.cells[i]);

        }
    }
    
    //hide rooms 
    public void Hide ()
    {
        for (int i = 0; i < cells.Count; i++)
        {
            cells[i].Hide();
        }
    }
    //show room
    public void show ()
    {
        for (int i= 0; i < cells.Count; i++ )
        {
            cells[i].Show();
        }
    }
}

