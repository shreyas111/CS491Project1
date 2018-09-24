using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class PositionObject1 : MonoBehaviour
{
    private TrackableBehaviour mTrackableBehaviour;
    public Vector3 posObject1;
    public bool detected;

    void Start()
    {

    }
    void Update()
    {
        posObject1 = this.transform.position;
        //Debug.Log("position of Object1 is :" + posObject1.x);
    }


}
