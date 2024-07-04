using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    [SerializeField] private int bumbCount = 0;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Wall")
        {
            bumbCount++;
            Debug.Log("You've bumb into a thing this many times: " + bumbCount);
        }
    }
}
