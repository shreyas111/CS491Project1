using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class PositionObject3 : MonoBehaviour {

    private TrackableBehaviour mTrackableBehaviour;
    public Vector3 posObject3;
    public bool detected = false;
    public bool detected3 = false;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        posObject3 = this.transform.position;
        //Debug.Log("position of Object3 is :" + posObject3.x);
    }
}
