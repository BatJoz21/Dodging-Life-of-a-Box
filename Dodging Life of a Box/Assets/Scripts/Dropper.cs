using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] private float timeToWait;

    private MeshRenderer mRenderer;
    private Rigidbody rb;

    void Start()
    {
        mRenderer = GetComponent<MeshRenderer>();
        mRenderer.enabled = false;
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Time.time > timeToWait)
        {
            mRenderer.enabled = true;
            rb.useGravity = true;
        }
    }
}
