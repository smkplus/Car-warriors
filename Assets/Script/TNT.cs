using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TNT : MonoBehaviour {


void OnTriggerEnter2D(Collider2D other) {
    if(other.tag != "Player"){
        return;
    }
    var player = other.GetComponent<Player>();
    player.Health -= 20;
    Destroy(gameObject);
}

}
