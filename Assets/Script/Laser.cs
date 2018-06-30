using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour {
    public LineRenderer line;

void Update(){
line.SetPosition(0,transform.position);
line.SetPosition(1,transform.position+ transform.up*30);
}
}
