using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndOfLevelScriptGuess : MonoBehaviour {

    void OnTriggerEnter(Collider other)
    {
        print("Congrats you have finished this game!");
    }
}
