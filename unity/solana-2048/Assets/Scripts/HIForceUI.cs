using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HIForceUI : MonoBehaviour {

    public static HIForceUI instance {  get; private set; }

    [SerializeField] private TextMeshProUGUI text;

    private void Awake() {
        instance = this;
    }

    public void SetText(float f) {
        int force = (int)Mathf.Round(f);
        text.text = "Force: " + (int) Mathf.Round(HICannon.instance.force);
    }
}
