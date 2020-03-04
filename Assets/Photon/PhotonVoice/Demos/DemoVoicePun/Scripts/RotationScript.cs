using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationScript : MonoBehaviour
{
    public Transform playerTransform;
    public Transform cameraTransform;

    void Start()
    {
        playerTransform = this.transform;
        cameraTransform = GameObject.Find("Main Camera").GetComponent<Transform>();
        
    }

    // Update is called once per frame
    void Update()
    {
        playerTransform.rotation = cameraTransform.rotation;
        //Debug.Log(cameraTransform.rotation);
    }
}
