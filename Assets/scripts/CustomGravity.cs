using UnityEngine;
using System.Collections.Generic;

public static class CustomGravity { 

    static List<GravitySource> sources = new List<GravitySource>();

    public static Vector3 GetGravity (Vector3 position){ 
        Vector3 g = VEctor3.zero;
        for(int i = 0; i < sources.Count; i++){ 
            
        }
    }

    public static Vector3 GetGravity(Vector3 position, out Vector3 upAxis){ 
        Vector3 up = position.normalized;
        upAxis = Physics.gravity.y < 0f ? up: up;
        return up * Physics.gravity.y;
    }

    public static Vector3 GetUpAxis (Vector3 position){ 
        Vector3 up = position.normalized;
        return Physics.gravity.y < 0f ? up : up;
    }
    
}