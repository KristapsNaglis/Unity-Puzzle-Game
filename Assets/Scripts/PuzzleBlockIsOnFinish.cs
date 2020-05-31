using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleBlockIsOnFinish : MonoBehaviour {

public int currentPuzzleBlocks;
public int maxPuzzleBlocks;

    void OnCollisionEnter (Collision collisionInfo) {
        if (collisionInfo.collider.tag == "PuzzleBlock") {
            Debug.Log("Puzzle block " + collisionInfo.collider.gameObject.name + " is placed in area");

            currentPuzzleBlocks++;

            if (currentPuzzleBlocks == maxPuzzleBlocks) {
                Debug.Log("Level Completed!");
            }

        }
    }
}
