using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SparkleHeavy : MonoBehaviour {

    private ParticleSystemRenderer psr;
    public GameObject plane;
    public GameObject cylinder;
    public GameObject capsule;
    public GameObject sphere;
    private Mesh mesh1;
    private Mesh mesh2;
    private Mesh mesh3;
    private Mesh mesh4;
    private Mesh[] psMesh;
    int mesh = 0;

    void Start () {
        mesh1 = plane.GetComponent<MeshFilter>().sharedMesh;
        mesh2 = cylinder.GetComponent<MeshFilter>().sharedMesh;
        mesh3 = capsule.GetComponent<MeshFilter>().sharedMesh;
        mesh4 = sphere.GetComponent<MeshFilter>().sharedMesh;

        psMesh = new Mesh[] { mesh1, mesh2, mesh3, mesh4 };
        psr = this.GetComponent<ParticleSystemRenderer>();

        InvokeRepeating("InvokeMeshChange", 5f, 2.0f);
    }

    void InvokeMeshChange()
    {
        if (mesh == psMesh.Length)
        {
            mesh = 0;
        }
        psr.mesh = psMesh[mesh];
        mesh++;
    }
}
