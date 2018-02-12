﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum MazeDirection {

    North,
    East,
    South,
    West
}

public static class MazeDirections
{
    //here we are setting the directions of the maze 
    public const int Count = 4;
    public static MazeDirection RandomValue
    {
        get
        {
            return (MazeDirection)Random.Range(0, Count);
        }
    }

    private static IntVector2[] vectors = 
    {
        new IntVector2(0, 1),
        new IntVector2(1, 0),
        new IntVector2(0, -1),
        new IntVector2(-1, 0)
    };

    public static IntVector2 ToIntVector2(this MazeDirection direction)
    {
        return vectors[(int)direction];
    }

}