﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Bake_NavMesh : MonoBehaviour
{
    public NavMeshSurface[] Surfaces;

    // Start is called before the first frame update
    void Start()
    {
        foreach (NavMeshSurface Surface in Surfaces)
        {
            Surface.BuildNavMesh();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
