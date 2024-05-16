using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 0.01f;
    [SerializeField] private float jumpSpeed = 0.01f;
    
    void Start()
    {
        
    }

    void Update()
    {
        Movement();
    }

    private void Movement()
    {
        float xValue = Input.GetAxis("Horizontal");
        float zValue = Input.GetAxis("Vertical");
        transform.Translate(xValue * moveSpeed * Time.deltaTime, 0, zValue * moveSpeed * Time.deltaTime);
    }
}
