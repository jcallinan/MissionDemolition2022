using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCam : MonoBehaviour
{
    static public GameObject POI; // point of interest

    [Header("Dynamic")]
    public float camZ; // the desired Z pos of the camera

    private void Awake()
    {
        camZ = this.transform.position.z;
    }

    private void FixedUpdate()
    {
        if (POI == null) return;
        //get the position of the POI
        Vector3 destination = POI.transform.position;
        destination.z = camZ;
        transform.position = destination;
    }

}
