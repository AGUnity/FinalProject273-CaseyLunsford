using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadUIEndOfKeepingHold : MonoBehaviour {

    public string TriggerName = string.Empty;

    void OnTriggerEnter(Collider Col)
    {
        SceneManager.LoadScene(0);
    }
}
