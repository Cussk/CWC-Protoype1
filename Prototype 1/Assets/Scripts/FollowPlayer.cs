using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player; // variable that links to an object in the game
    public Vector3 offset = new Vector3(0, 5, -7); //variable for offsetting camera

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate() //updates after object updates to prevent stuttering effect
    {   
        //offset camera from player position with Vector3
        transform.position = player.transform.position + offset; // takes the position of the camera and makes it equal the position of the object defined by the variable
    }
}
