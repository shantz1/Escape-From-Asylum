using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostController2 : MonoBehaviour
{
    public bool playerEntered = false;
    public float speed = 1;
    

    public float upperLimit;
    private void Update()
    {
        if (playerEntered)
        {
            transform.position += new Vector3(0, 0, -speed * Time.deltaTime);
            if(transform.position.z > upperLimit)
            {
                Destroy(gameObject);
            }
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            playerEntered = true;
            ScoundManager.Instance.PlaySound(ScoundManager.Instance.ghostEntry2);
        }    
    }
}
