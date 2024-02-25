using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HITargetBoard : MonoBehaviour {
    public static HITargetBoard instance {  get; private set; }

    [SerializeField] HITarget target;

    private void Awake() {
        instance = this;
    }

    public void moveTarget(float x, float y) {
        target.SetPosition(x, y);
    }
}
