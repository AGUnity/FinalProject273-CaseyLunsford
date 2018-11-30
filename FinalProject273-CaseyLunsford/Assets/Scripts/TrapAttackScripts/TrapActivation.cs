using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapActivation : MonoBehaviour {

    public GameObject Object1;
    public GameObject Object2;
    private void OnTriggerEnter()
    {
        Destroy(Object1);
        Destroy(Object2);
    }
}
