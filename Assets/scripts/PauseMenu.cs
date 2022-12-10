using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; 

public class PauseMenu : MonoBehaviour
{
    public void Activat()
    {
        gameObject.SetActive(true);
        
    }
   
     public void Pause()
    {
        Time.timeScale = 0f; 
    }

    public void Resume()
    {
        Time.timeScale = 1f;
        gameObject.SetActive(false);
    }

    public void Quitrr()
    {
        Application.Quit();
        Debug.Log("player has laft the bilding");
    }

    void Start()
        {

        }

    // Update is called once per frame
    void Update()
    {
       
    }
}
