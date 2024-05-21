using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ro_around : MonoBehaviour
{
   public float rotate_around_speed;
   public Transform sun;
    
    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(sun.position,Vector3.up,rotate_around_speed*Time.fixedDeltaTime);
    }
}
