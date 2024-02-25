using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HIGameInput : MonoBehaviour {

    public event EventHandler OnFire;

    public static HIGameInput instance { get; private set; }

    private bool wait = false;

    private void Awake() {
        instance = this;
    }

    private void Start() {
        Solana2048Service.Instance.OnFireFinish += SolanaService_OnFireFinish;
    }

    private void SolanaService_OnFireFinish(object sender, EventArgs e) {
        Debug.Log("NO LONGER WAITING FOR RESPONSE, CAN FIRE AGAIN");
        wait = false;
    }

    private void Update() {
        if (Input.GetKey(KeyCode.F) && !wait) {
            Debug.Log("Fired OnFire");
            OnFire?.Invoke(this, EventArgs.Empty);
            wait = true;
        }

        if (Input.GetKey(KeyCode.R)) {
            wait = false;
        }
    }

    public Vector2 GetRotationVector() {
        Vector2 inputVector = new Vector2(0, 0);

        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow)) {
            inputVector.y += 1;
        }
        if (Input.GetKey(KeyCode.S ) || Input.GetKey(KeyCode.DownArrow)) {
            inputVector.y -= 1;
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow)) {
            inputVector.x += 1;
        }
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)) {
            inputVector.x -= 1;
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
