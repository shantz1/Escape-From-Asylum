using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorControllerAnimation : MonoBehaviour
{
    public Animator animator;


    private void OnTriggerEnter(Collider other)
    {
        
        animator.SetBool("isOpen", true);
        ScoundManager.Instance.PlaySound(ScoundManager.Instance.doorOpen);
    }

    private void OnTriggerExit(Collider other)
    {
        
        animator.SetBool("isOpen", false);
        ScoundManager.Instance.PlaySound(ScoundManager.Instance.doorClose);
    }
}
