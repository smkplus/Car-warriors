using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    public float moveSpeed = 5;
    public GameObject bulletPrefab,rocketPrefab,laserObject;
    private float startTime,nextTime = 2;
    public float delay = 2;
    public Transform shotPos;
    public enum Weapons{Laser,MachineGun,RocketLauncher}
    public Weapons currentWeapon;
    public bool isfaceRight;

    void Start(){
nextTime = delay;
}

void Update() {
Movement();
BulletReloader();
    laserObject.SetActive(currentWeapon == Weapons.Laser && Input.GetKey(KeyCode.Space));

}

float h,v;    
/// <summary>
/// حرکت کردن بازیکن
/// </summary>
void Movement(){
h = Input.GetAxisRaw("Horizontal");    
v = Input.GetAxisRaw("Vertical");   
if(h != 0 || v != 0){

    Flip();
}


transform.position += new Vector3(h,v,0)*moveSpeed*Time.deltaTime;
}

/// <summary>
/// ریلود کردن تیر
/// </summary>
void BulletReloader(){
startTime += 0.1f;
//print(startTime);
if(startTime >= nextTime && Input.GetKey(KeyCode.Space)){
    Shot();
startTime = 0;
}
}

void Flip(){
    var rot = transform.eulerAngles;
float degree = Mathf.Atan2(-h, v) * (180 / Mathf.PI);
//print(degree);
   rot.z = degree;
    transform.eulerAngles = rot;
}

void Shot(){
GameObject spawn;
    if(currentWeapon == Weapons.MachineGun){
    spawn = Instantiate(bulletPrefab,shotPos.position,transform.rotation);
    }else if(currentWeapon == Weapons.RocketLauncher){
    spawn = Instantiate(rocketPrefab,shotPos.position,transform.rotation);
    }


}




}
