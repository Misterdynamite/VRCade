using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pellet : MonoBehaviour
{
    
    private void OnTriggerEnter(Collider other) {
        
        if (other.tag == "Player") {

            GameObject.Find("Maze").GetComponent<MazeGenerator>().pelletCount--;
            Destroy(gameObject);

        }

    }

}
