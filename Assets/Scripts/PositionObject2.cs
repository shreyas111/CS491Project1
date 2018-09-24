using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class PositionObject2 : MonoBehaviour
{
    private TrackableBehaviour mTrackableBehaviour;
    public Vector3 posObject2;
    public bool detected = false;

    void Start()
    {

    }
    void Update()
    {
        posObject2 = this.transform.position;
        //Debug.Log("position of Object2 is :" + posObject2.x);
    }


}
