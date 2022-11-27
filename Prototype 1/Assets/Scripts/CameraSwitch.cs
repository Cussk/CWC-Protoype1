using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitch : MonoBehaviour
{
    public Camera firstPersonCamera;
    public Camera overheadCamera;

    // Start is called before the first frame update
    void Start()
    {
        // disable FPS camera,
        // and enable overhead camera.
        firstPersonCamera.enabled = false;
        overheadCamera.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C)){

        // enable FPS camera,
        // and disable overhead camera.
        firstPersonCamera.enabled = !firstPersonCamera.enabled;
        overheadCamera.enabled = !overheadCamera.enabled;
        }
    }
}
