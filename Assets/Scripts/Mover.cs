using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float xValue = 0f;
    [SerializeField] float yValue = 0f;
    [SerializeField] float zValue = 0f;
    [SerializeField] float movSpeed = 10f;
    void Start()
    {
        
    }

    void Update()
    {
        float xValue = Input.GetAxis("Horizontal")*Time.deltaTime*movSpeed;
        float zValue = Input.GetAxis("Vertical")*Time.deltaTime*movSpeed;
        transform.Translate(xValue,0,zValue);

    }
}
