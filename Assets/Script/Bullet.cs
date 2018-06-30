using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {
    public float moveSpeed = 15;

void Update(){
    transform.position += transform.up*Time.deltaTime*moveSpeed;
}

}
