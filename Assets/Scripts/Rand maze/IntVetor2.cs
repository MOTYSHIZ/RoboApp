using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public struct IntVector2
 {
    //this set of code is finding the locations to then place the next setof quads
        public int x, z;
        public IntVector2 (int x, int z)
        {
            this.x = x;
            this.z = z;
        }
    
    public static IntVector2 operator + (IntVector2 a, IntVector2 b)
    {
        a.x += b.x;
        a.z += b.z;
        return a;
    }

}

