using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColisorTrigger : MonoBehaviour {
    void OnTriggerEnter(Collider colisor) {
        if(colisor.gameObject.tag == "Player") {
            Debug.Log("Tocou!");
        }
    }

}
