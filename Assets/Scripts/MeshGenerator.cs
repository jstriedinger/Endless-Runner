using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MeshFilter))]
public class MeshGenerator : MonoBehaviour
{
    Mesh mesh;
    Vector3[] vertices;
    int[] triangles;


    private void Awake()
    {
        mesh = GetComponent<MeshFilter>().mesh;
    }
    // Start is called before the first frame update
    void Start()
    {
        MakeMeshData();
        UpdateMesh();
    }

    private void UpdateMesh()
    {
        mesh.Clear();
        mesh.vertices = vertices;
        mesh.triangles = triangles;
    }

    void MakeMeshData()
    {
        //vertices
        vertices = new Vector3[] { new Vector3(0,0,0), new Vector3(0,0.7f,0),
                                    new Vector3(1.5f,0.35f,0)};

        //integers
        triangles = new int[] { 0, 1, 2 };

    }


}
