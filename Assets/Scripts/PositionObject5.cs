using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class PositionObject5 : MonoBehaviour
{
    private TrackableBehaviour mTrackableBehaviour;
    public Vector3 posObject5;
    public bool detected = false;
    public bool detected5 = false;

    void Start()
    {

    }
    void Update()
    {
        posObject5 = this.transform.position;
    }


}
