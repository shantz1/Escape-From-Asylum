using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Credits : MonoBehaviour
{

    private void Start()
    {
        Cursor.lockState = CursorLockMode.None;
    }

    public void BackToMain()
    {
            
            SceneManager.LoadScene("MainMenu");
     

    }



}
