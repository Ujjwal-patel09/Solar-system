using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class planet_rotation : MonoBehaviour
{
    public float rotation_speed;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0,rotation_speed*Time.fixedDeltaTime,0);
    }
}
