using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //public variables
    public Camera mainCamera; //overhead camera
    public Camera firstPersonCamera; // firstperson camera
    public KeyCode switchKey; //key for switching between cameras
    public string inputID; //inputID for multiple players

    //private variables
    private float speed = 20.0f; //variable for speed of vehicle using float(decimal)
    private float turnSpeed = 50.0f; //variable for speed on horizontal axis
    private float horizontalInput; //variable for player input on horizontal axis
    private float verticalInput; //variable for player input on vertical axis (forwards and backwards)

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        verticalInput = Input.GetAxis("Vertical" + inputID); //links vertical axis as below
        horizontalInput = Input.GetAxis("Horizontal" + inputID); // links input variable to player input for horizontal axis in Unity and checks which player is inputting the keypress
        
       // Move the vehicle forward
       transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput); //use transform component to move along x, y, z axes 
       //Vector3 is shorthand for x,y,z axes, forward is short for 0,0,1
       //Time.deltaTime changes update to per second, multiplied by sped variable frames each second
       //used player input for forward and backward movement

        //transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * horizontalInput); //transform along horizontal axis according to player input
    
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * horizontalInput); //rotates vehicle on y axis while turning to give vehicle more realistic turning motion

        if(Input.GetKeyDown(switchKey)) //toggles main and firstperson cameras when pressing defined switchkey
        {
            mainCamera.enabled = !mainCamera.enabled;
            firstPersonCamera.enabled = !firstPersonCamera.enabled;
        }

    }
}
