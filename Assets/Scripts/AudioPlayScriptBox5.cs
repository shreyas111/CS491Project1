using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class AudioPlayScriptBox5 :  MonoBehaviour, ITrackableEventHandler
{
    private TrackableBehaviour mTrackableBehaviour;
    public AudioSource audioSource;
    public GameObject Object;


    void Start()
    {
        mTrackableBehaviour = GetComponent<TrackableBehaviour>();
        if (mTrackableBehaviour)
        {
            mTrackableBehaviour.RegisterTrackableEventHandler(this);
        }
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
            Object.GetComponent<PositionObject5>().detected = true;
            Object.GetComponent<PositionObject5>().detected5 = true;


        }
        else
        {
            // Stop audio when target is lost
            Object.GetComponent<PositionObject5>().detected = false;
            Object.GetComponent<PositionObject5>().detected5 = false;
            //lightObject.transform.position = new Vector3(-2, -2, -2);
        }
    }
}

