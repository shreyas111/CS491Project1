using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class PositionObject4 : MonoBehaviour
{
    private TrackableBehaviour mTrackableBehaviour;
    public Vector3 posObject4;
    public bool detected = false;

    void Start()
    {

    }
    void Update()
    {
        posObject4 = this.transform.position;
        //Debug.Log("position of Object2 is :" + posObject2.x);
    }


}
