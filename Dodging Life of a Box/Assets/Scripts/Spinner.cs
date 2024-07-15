using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField] private float rotationSpeed = 1.0f;

    void Update()
    {
        transform.Rotate(0, rotationSpeed, 0);
    }
}
