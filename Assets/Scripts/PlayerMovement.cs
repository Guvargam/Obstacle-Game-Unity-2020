using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{  
    [SerializeField]  float speed = 1.2f;
    //[SerializeField] float yValue = 0.02f; 
    [SerializeField] float yValue = 0; 
    // Start is called before the first frame update
    void Start()
    {
       // PrintInstructions();
       // PrintDebug();   
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMove();
        Quit();
        
    }

    void PrintDebug()
    {
        Debug.Log("Player position X value is: " + transform.position.x);
    }

    void PrintInstructions()
    {
        Debug.Log("Welcome to the Game!");
        Debug.Log("Here we are playing game boy,");
        Debug.Log("Go and grap a token to WİN!!");
    }

    void PlayerMove()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * speed;

        //transform.Translate(xValue,yValue,zValue);
        transform.Translate(xValue,yValue, zValue);
    }

    void Quit()
    {
        if (Input.GetKey("escape"))
        {
            Application.Quit();
        }
    }

}
