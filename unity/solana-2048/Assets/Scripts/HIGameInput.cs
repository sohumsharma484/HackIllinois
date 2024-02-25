using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HIGameInput : MonoBehaviour {

    public event EventHandler OnFire;

    private void Start() {
        
    }

    private void Update() {
        if (Input.GetKey(KeyCode.KeypadEnter)) {
            OnFire?.Invoke(this, EventArgs.Empty);
        }
    }

    public Vector2 GetRotationVector() {
        Vector2 inputVector = new Vector2(0, 0);

        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow)) {
            inputVector.x -= 1;
        }
        if (Input.GetKey(KeyCode.S ) || Input.GetKey(KeyCode.DownArrow)) {
            inputVector.x += 1;
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow)) {
            inputVector.y += 1;
        }
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)) {
            inputVector.y -= 1;
        }

        return inputVector;
    }

    public float GetForce() {
        float input = 0f;

        if (Input.GetKey(KeyCode.E)) {
            input += 1f;
        }
        if (Input.GetKey(KeyCode.Q)) {
            input -= 1f;
        }

        return input;
    }
}
