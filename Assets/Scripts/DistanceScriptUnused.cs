using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DistanceScript : MonoBehaviour {

    public GameObject object1;
    public GameObject object2;
    public float distance;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
         if(object1 != null && object2 !=null)
        {
            distance = Vector3.Distance(object1.transform.position, object2.transform.position);
            Debug.Log("Distance is " + distance);
        }
		
	}
}
