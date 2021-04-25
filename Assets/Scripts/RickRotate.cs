using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class RickRotate : MonoBehaviour
{
    [SerializeField]
    private float rotationSpeedX = 5.5f;
    [SerializeField]
    private float rotationSpeedY = 2.0f;
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0,rotationSpeedX*Time.deltaTime,rotationSpeedY*Time.deltaTime);
    }
}
