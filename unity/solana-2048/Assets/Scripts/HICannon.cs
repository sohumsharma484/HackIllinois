using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HICannon : MonoBehaviour {
    public static HICannon instance {  get; private set; }

    [SerializeField] private float rotateSpeed = 50f;
    [SerializeField] private float forceChangeSpeed = 10f;
    [SerializeField] private HIGameInput gameInput;

    public float force = 50f;

    private void Start() {
        instance = this;
    }

    // Update is called once per frame
    void Update() {
        Vector2 inputVector = gameInput.GetRotationVector();
        Vector3 rotDir = new Vector3(inputVector.x, inputVector.y, 0f) * rotateSpeed * Time.deltaTime;
        Vector3 playerRot = transform.rotation.eulerAngles;
        playerRot += rotDir;
        playerRot = Quaternion.Euler(playerRot).eulerAngles;
        transform.rotation = Quaternion.Euler(playerRot);

        float inputForce = gameInput.GetForce();
        force += inputForce * forceChangeSpeed * Time.deltaTime;
        if (force < 0f) {
            force = 0;
        }
        HIForceUI.instance.SetText(force);
    }
}
