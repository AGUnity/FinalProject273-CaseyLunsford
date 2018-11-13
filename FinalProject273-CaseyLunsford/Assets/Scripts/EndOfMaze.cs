using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndOfMaze : MonoBehaviour {

    void OnTriggerEnter(Collider Col)
    {
        print("End of Maze!");
    }
}
