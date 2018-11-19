using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EOLElevatorTrigger : MonoBehaviour {

    public Animator TargetAnimator = null;
    public string TriggerName = string.Empty;

    void OnTriggerEnter(Collider Col)
    {
        TargetAnimator.SetTrigger(TriggerName);
    }
}
