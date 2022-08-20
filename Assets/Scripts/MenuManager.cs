using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour

{
    private void Start()
    {
        Cursor.lockState = CursorLockMode.None;
    }


    public Text progessToShow;

    public void PlayGame()
    {
        StartCoroutine(PlayGameAsync());
        
    }
   
    IEnumerator PlayGameAsync()
    {

        AsyncOperation loadMyScene = SceneManager.LoadSceneAsync("Show");

        while(!loadMyScene.isDone)
        {
            
            progessToShow.text = loadMyScene.progress.ToString() + "%"; 
            yield return null;
        }
        
    }


    public void Credits()
    {
        SceneManager.LoadScene("Credits");
      
    }




    public void ExitGame()
    {
        Application.Quit();
    }




}
