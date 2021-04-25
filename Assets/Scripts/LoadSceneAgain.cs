using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneAgain : MonoBehaviour
{
    
    private void OnCollisionEnter(Collision other)
    {
        if (other.collider.CompareTag("Player"))
        {
            GetComponent<MeshRenderer>().material.color = Color.red;
            LoadScene(SceneManager.GetActiveScene().name);

        }
        
    }
    
    public void LoadScene(string scenename)
    {
        Debug.Log("sceneName to load: " + scenename);
        SceneManager.LoadScene(scenename);
    }
}
