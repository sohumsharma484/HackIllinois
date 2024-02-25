using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HICannon : MonoBehaviour {
    public static HICannon instance {  get; private set; }

    [SerializeField] private float rotateSpeed = 50f;
    [SerializeField] private float forceChangeSpeed = 10f;
    [SerializeField] private HIGameInput gameInput;

    public float force = 50f;

    private void Awake() {
        instance = this;
    }

    // Update is called once per frame
    void Update() {
        Vector2 inputVector = gameInput.GetRotationVector();
        Vector3 rotDir = new Vector3(0f, inputVector.x, inputVector.y) * rotateSpeed * Time.deltaTime;
        Vector3 playerRot = transform.rotation.eulerAngles;
        playerRot += rotDir;
        playerRot = Quaternion.Euler(playerRot).eulerAngles;
        // Bounding
        if (playerRot.y < 180f && playerRot.y> 90f) { playerRot.y = 180f; }
        if (playerRot.y < 90f) { playerRot.y = 360f; }
        if (playerRot.z >270f) { playerRot.z = 0f; }
        if (playerRot.z > 50f) { playerRot.z = 50f; }

        transform.rotation = Quaternion.Euler(playerRot);

        float inputForce = gameInput.GetForce();
        force += inputForce * forceChangeSpeed * Time.deltaTime;
        if (force < 0f) {
            force = 0;
        }
        HIForceUI.instance.SetText(force);
    }
}
