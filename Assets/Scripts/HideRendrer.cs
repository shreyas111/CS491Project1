using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideRendrer : MonoBehaviour {

    void Awake()
    {
        this.GetComponent<MeshRenderer>().enabled=false;
        //Debug.Log("Awake Called");

        //this.gameObject.SetActive(false);
    }
    // Use this for initialization
    void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
        
    }
}
