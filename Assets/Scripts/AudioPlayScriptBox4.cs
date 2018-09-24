using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class AudioPlayScriptBox4 : MonoBehaviour, ITrackableEventHandler
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
            Object.GetComponent<PositionObject4>().detected = true;


        }
        else
        {
            // Stop audio when target is lost
            Object.GetComponent<PositionObject4>().detected = false;
        }
    }
}

