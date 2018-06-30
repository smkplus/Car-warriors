using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SleepPotion : MonoBehaviour {

void OnTriggerEnter2D(Collider2D other)
{
        if(other.tag != "Player"){
        return;
    }

    var player = other.GetComponent<Player>();
    player.StartCoroutine(player.Sleep(2));
    Destroy(gameObject);
}

}
