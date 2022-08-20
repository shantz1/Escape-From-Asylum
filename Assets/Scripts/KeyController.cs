using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyController : MonoBehaviour
{
    public bool canCollect = false;
    public bool isCollected;


    private void Update()
    {
        if (canCollect && !isCollected)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                isCollected = true;
                UIManager.Instance.SetPromptText("");
                gameObject.SetActive(false);

            }
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            canCollect = true;
           UIManager.Instance.SetPromptText("Please E to Collect the Key");
           
              
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            canCollect = false;
            UIManager.Instance.SetPromptText("");


        }
    }
}
