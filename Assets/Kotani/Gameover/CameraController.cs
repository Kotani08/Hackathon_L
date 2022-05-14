using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField]
    public GameObject player;
    private Vector3 cameraVec;
    private Vector3 playercamera;
    void Start()
    {
        playercamera.x = player.transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        cameraVec.x = player.transform.position.x+300f;
        if(playercamera.y >= player.transform.position.y +280f)
        {
            cameraVec.y = -280f;
        }
        else{cameraVec.y = player.transform.position.y;}
        cameraVec.z = -10.0f;
        this.transform.position  = cameraVec;
        //cameraVec.y = player.transform.position.y; 
    }
}
