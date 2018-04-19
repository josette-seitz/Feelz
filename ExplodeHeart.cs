using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplodeHeart : MonoBehaviour {

    public GameObject heartWorld;
    public GameObject psSparkle;
    public GameObject lastPS;

    void Start () {
        Invoke("DestoryHeartWorld", 27.25f);
        Invoke("LastPS", 54f);
    }

    void DestoryHeartWorld()
    {
        Destroy(heartWorld);
        Camera.main.clearFlags = CameraClearFlags.SolidColor;
        Camera.main.backgroundColor = Color.black;
        psSparkle.SetActive(true);
    }

    void LastPS()
    {
        Destroy(psSparkle);
        lastPS.SetActive(true);
    }
}
