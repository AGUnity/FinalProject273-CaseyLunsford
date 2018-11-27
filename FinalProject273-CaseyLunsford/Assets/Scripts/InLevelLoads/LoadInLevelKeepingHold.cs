using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadInLevelKeepingHold : MonoBehaviour {

    public string TriggerName = string.Empty;

    void OnTriggerEnter()
    {
        print("End of Maze!");
        SceneManager.LoadScene(2);
    }
}
