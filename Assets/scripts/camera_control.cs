using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class camera_control : MonoBehaviour
{
    public GameObject[] planet_cam_pos;
    public GameObject sun;
    int current_planet = 0;


    private void Update() {
        
        // for changing position //
        transform.position = new Vector3(planet_cam_pos[current_planet].transform.position.x,planet_cam_pos[current_planet].transform.position.y,planet_cam_pos[current_planet].transform.position.z);
        transform.SetParent(planet_cam_pos[current_planet].transform);//for changing rotation according to planet//
        transform.LookAt(sun.transform.position);//for looking at sun constantly//

        if(Input.GetKeyDown(KeyCode.Space)){//for switching the planet//
            planet_switch();
        }
    }

    void planet_switch(){

        current_planet++;
        if(current_planet == planet_cam_pos.Length){
            current_planet = 0;
        }
    }
}
