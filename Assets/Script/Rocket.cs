using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Rocket : MonoBehaviour {
    public Transform Target;
    private Rigidbody2D myBody;
    public float Speed = 10,turnSpeed = 5;

    void Start(){
        myBody = GetComponent<Rigidbody2D>();
    }
float lastTurn;
void Update()
{
     Target = GameObject.FindGameObjectWithTag("Enemy").transform;

    var newRotation = Quaternion.LookRotation(transform.position - Target.transform.position, 
    Vector3.forward);
newRotation.x = 0.0f;
newRotation.y = 0.0f;
transform.rotation = Quaternion.Slerp(transform.rotation, 
newRotation, Time.deltaTime * turnSpeed);
myBody.velocity=transform.up * Speed;
if(turnSpeed<40f){
    lastTurn+=Time.deltaTime*Time.deltaTime*50f;
    turnSpeed+=lastTurn;
}
}

private void OnTriggerEnter2D(Collider2D other) {
    if(other.gameObject.tag == "Enemy"){

       // Destroy(other.gameObject);
    Destroy(gameObject);
    }
}

}
