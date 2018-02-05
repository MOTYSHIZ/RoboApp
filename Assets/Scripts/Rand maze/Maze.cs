﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Maze : MonoBehaviour {

    public int sizeX, sizeZ;                // the size of the room

    public MazeCell cellPrefab;             //grab the cellPrefab

    private MazeCell[,] cells;              //set an arry for ....

    public float generationStepDelay;

    public IntVector2 size;


    public IntVector2 RandomCoordinates
    {
        get
        {
            return new IntVector2(Random.Range(0, size.x), Random.Range(0, size.z));
        }

    }

    public bool ContainsCoordinates (IntVector2 coordinate)
    {
        return coordinate.x >= 0 && coordinate.x < size.x && coordinate.z >= 0 && coordinate.z < size.z;

    }



    public IEnumerator Generate ()                     //generate the floor
    {
        WaitForSeconds delay = new WaitForSeconds(generationStepDelay);
        cells = new MazeCell[size.x, size.z];     //set the arry for the size of the room
        IntVector2 coordinates = RandomCoordinates;
        while (ContainsCoordinates (coordinates))
        {
            yield return delay;
            CreateCell(coordinates);
            coordinates.z += 1;
        }
       
    }





    private void CreateCell (IntVector2 coordinates)
    {

        MazeCell newCell = Instantiate(cellPrefab) as MazeCell;
        cells[coordinates.x, coordinates.z] = newCell;
        newCell.coordinates = coordinates;
        newCell.name = "Maze Cell " + coordinates.x + ", " + coordinates.z;
        newCell.transform.parent = transform;
        newCell.transform.localPosition = new Vector3(coordinates.x - sizeX * 0.5f + 0.5f, 0f, coordinates.z - sizeZ * 0.5f + 0.5f);

    }

    public IntVector2 RandomCoordinates     //to make create cell and generate  work
    {
        get
        {
            return new IntVector2(Random.Range(0, size.x), Random.Range(0, size.z));
        }
    }

    public bool ContainsCoordinates (IntVector2 coordinate)
    {
        return coordinate.x >= 0 && coordinate.x < size.x && coordinate.z >= 0 && coordinate.z < size.z;
    }
}
