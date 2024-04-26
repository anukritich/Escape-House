using UnityEngine.SceneManagement;
using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour

{
   
   
    public void Play()
    {
        SceneManager.LoadScene("Room 1"); ;
    }
   
    
   
  
    public void Quit()
    {
        Application.Quit();
    }

}


