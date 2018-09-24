using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class AudioPlayScript : MonoBehaviour, ITrackableEventHandler
{
    private TrackableBehaviour mTrackableBehaviour;
    public AudioSource audioSource;
    //public AudioClip ap;
    public Vector3 position1;
    public GameObject Object;
    

    void Start()
    {
        mTrackableBehaviour = GetComponent<TrackableBehaviour>();
        if (mTrackableBehaviour)
        {
            mTrackableBehaviour.RegisterTrackableEventHandler(this);
        }
        //a.clip = ap
        //lightObject = GameObject.Find("light_wall_3");
       
    }
    void Update()
    {

    }

    public void OnTrackableStateChanged(
                                    TrackableBehaviour.Status previousStatus,
                                    TrackableBehaviour.Status newStatus)
    {
        if (newStatus == TrackableBehaviour.Status.DETECTED ||
            newStatus == TrackableBehaviour.Status.TRACKED ||
            newStatus == TrackableBehaviour.Status.EXTENDED_TRACKED)
        {
            // Play audio when target is found
            audioSource.Play();
            Object.GetComponent<PositionObject1>().detected = true;

        }
        else
        {
            // Stop audio when target is lost
            //lightObject.transform.position = new Vector3(-2, -2, -2);
            Object.GetComponent<PositionObject1>().detected = false;
        }
    }
}   
