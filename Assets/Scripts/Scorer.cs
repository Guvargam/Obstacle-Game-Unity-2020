using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    int _score = 0;
    private void OnCollisionEnter(Collision other)
    {
        if (!other.collider.CompareTag("Hit"))
        {
            _score++;
            Debug.Log("You have bumped into a thing this many times :" + _score);
            
        }
        
    }
}
