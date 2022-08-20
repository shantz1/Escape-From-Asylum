using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    public GameObject doorObject;
    public bool canOpen = false;
    public bool isLocked = false;
    public KeyController key; 

    

    private void Update()
    {
        if (canOpen && !isLocked)
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                if (doorObject.activeSelf)
                {
                    doorObject.SetActive(false);
                    ScoundManager.Instance.PlaySound(ScoundManager.Instance.doorOpen);
                }
                else
                {
                    doorObject.SetActive(true);
                    ScoundManager.Instance.PlaySound(ScoundManager.Instance.doorClose);
                }
                
            }
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            canOpen = true;
            if (!isLocked)
                UIManager.Instance.SetPromptText("Press F to open or close the door");
            else
            {
                if (key.isCollected)
                {   isLocked = false;
                    UIManager.Instance.SetPromptText("Press F to open or close the door");
                }
                else
                UIManager.Instance.SetPromptText("Find Key to Unlock the door");

            }


            }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            canOpen = false;
            UIManager.Instance.SetPromptText("");
            

        }
    }



}
