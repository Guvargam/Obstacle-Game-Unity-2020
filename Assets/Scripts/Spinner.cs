using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField]
    private float xAngle = 0f;
    [SerializeField]
    private float yAngle = 50f;
    [SerializeField]
    private float zAngle = 0f;
    

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(xAngle, yAngle * Time.deltaTime,zAngle);       
    }
}
