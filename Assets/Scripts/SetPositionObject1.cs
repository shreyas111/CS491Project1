using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class SetPositionObject1 : MonoBehaviour, ITrackableEventHandler
{
    private TrackableBehaviour mTrackableBehaviour;
    //private ImageTargetBehaviour mImageTargetBehaviour = null;
    //public GameObject position1;
    //public ImageTarget target1;
    private Vector3 position1;
    private bool getPosition = false;
    public GameObject object1;

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
        if (getPosition)
        {
            position1 = object1.transform.position;
            Debug.Log("X is: " + position1.x + " Y is: " + position1.z + " Z is: " + position1.z);
            object1.GetComponent<PositionObject1>().posObject1 = position1;
        }
        else
        {
            position1 = new Vector3(0, 0, 0);
            //Debug.Log("X is: " + position1.x + " Y is: " + position1.z + " Z is: " + position1.z);
            object1.GetComponent<PositionObject1>().posObject1 = position1;
        }
    }

    public void OnTrackableStateChanged(
                                    TrackableBehaviour.Status previousStatus,
                                    TrackableBehaviour.Status newStatus)
    {
        if (newStatus == TrackableBehaviour.Status.DETECTED ||
            newStatus == TrackableBehaviour.Status.TRACKED ||
            newStatus == TrackableBehaviour.Status.EXTENDED_TRACKED)
        {
            getPosition = true;
            //Debug.Log("PositionObject1 Object found.");
        }
        else
        {
            getPosition = false;
            //Debug.Log("PositionObject1 Object Lost in Unity.");
        }
    }
}
