using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class TrackableAll : MonoBehaviour, ITrackableEventHandler
{
    private TrackableBehaviour mTrackableBehaviour;

    void Start()
    {
        mTrackableBehaviour = GetComponent<TrackableBehaviour>();
        if (mTrackableBehaviour)
        {
            mTrackableBehaviour.RegisterTrackableEventHandler(this);
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
            if(gameObject.name == "A")
                States.State_A = true;
            if (gameObject.name == "B")
                States.State_B = true;
            if (gameObject.name == "C")
                States.State_C = true;
            if (gameObject.name == "*")
                States.State_Next = true;
        }
        else
        {
            if (gameObject.name == "A")
                States.State_A = false;
            if (gameObject.name == "B")
                States.State_B = false;
            if (gameObject.name == "C")
                States.State_C = false;
            if (gameObject.name == "*")
                States.State_Next = false;
        }
    }
}
