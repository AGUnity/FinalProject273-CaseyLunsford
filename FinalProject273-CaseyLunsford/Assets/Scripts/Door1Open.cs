using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door1Open : MonoBehaviour {

    public Animator TargetAnimator = null;
    public string TriggerName1 = string.Empty;

    void OnTriggerEnter(Collider Col)
    {
        TargetAnimator.SetTrigger(TriggerName1);
    }
}
