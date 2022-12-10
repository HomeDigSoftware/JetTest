using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("GamePlay");
        Time.timeScale = 1f; 
    }

   
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
