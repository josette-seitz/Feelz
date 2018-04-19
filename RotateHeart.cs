using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateHeart : MonoBehaviour {

    private Transform childHeartPS;

    void Start () {
        iTween.RotateTo(this.gameObject, iTween.Hash("y", this.gameObject.transform.eulerAngles.y + 180,
                                 "time", 1.70f,
                                 "easetype", "linear",
                                 "looptype", "pingPong"));

        childHeartPS = this.gameObject.transform.GetChild(1);
        Invoke("HeartPS", 13.5f);
    }

    void HeartPS()
    {
        childHeartPS.gameObject.SetActive(true);
    }
}
