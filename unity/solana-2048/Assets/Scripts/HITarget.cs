using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HITarget : MonoBehaviour {
    public void SetPosition(float x, float y) {
        transform.localPosition = new Vector3(x, y, 0f);
    }
}
