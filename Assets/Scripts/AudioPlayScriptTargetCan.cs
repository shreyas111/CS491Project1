using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class AudioPlayScriptTargetCan : MonoBehaviour, ITrackableEventHandler
{
    private TrackableBehaviour mTrackableBehaviour;
    public AudioSource audioSource;
    //public AudioClip ap;
    public Vector3 position1;
    public GameObject Object;
    

    void Awake()
    {
        //Object = GameObject.Find("light_wall_3");
    }
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
            Object.GetComponent<PositionObject3>().detected = true;
            Object.GetComponent<PositionObject3>().detected3 = true;


        }
        else
        {
            // Stop audio when target is lost
            Object.GetComponent<PositionObject3>().detected = false;
            Object.GetComponent<PositionObject3>().detected3 = false;
            //lightObject.transform.position = new Vector3(-2, -2, -2);
        }
    }
}
