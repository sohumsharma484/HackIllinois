using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HICannonball : MonoBehaviour {

    public static HICannonball instance { get; private set; }


    private void Awake() {
        instance = this;
    }

    public void ResetPos() {
        transform.localPosition = new Vector3 (0, 0, 10);
    }

    public void SetPos(int xloc, int yloc) {
        transform.localPosition = new Vector3(xloc, yloc, 0.5f);
    }
}
