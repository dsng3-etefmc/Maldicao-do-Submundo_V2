using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>A class that handles dialogue</summary>
public class Follow : MonoBehaviour {
    public GameObject Target;

    void Start() {
        Target = Target != null ? Target : GameObject.FindWithTag("Player");
    }

    // Updates camera position based on its target
    void Update() {
        if (Target) {
            this.transform.position = Target.transform.TransformPoint(new Vector3( 0f, 0f, -10f));
            this.transform.LookAt(Target.transform);
        }
    }
}
