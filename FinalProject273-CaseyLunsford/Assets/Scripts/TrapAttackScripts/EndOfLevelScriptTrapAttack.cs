using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndOfLevelScriptTrapAttack : MonoBehaviour {

    void Update()
    {
        if (Input.GetKey("escape"))
        {
            Application.Quit();
        }
    }

    void OnTriggerEnter(Collider other)
    {
        print("Congrats you have finished this game!");
    }
}
