using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Floor1WallDestroy : MonoBehaviour {
    public GameObject Object;
    private void OnTriggerEnter()
    {
        Destroy(Object);
        print("Something was Destroyed on Floor 1");
    }
}
