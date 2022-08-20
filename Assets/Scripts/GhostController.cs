using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostController : MonoBehaviour
{
    public bool playerEntered = false;
    public float speed = 1;
    

    public float upperLimit;
    private void Update()
    {
        if (playerEntered)
        {
            transform.position += new Vector3(0, speed * Time.deltaTime, 0);
            if(transform.position.y > upperLimit)
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
            ScoundManager.Instance.PlaySound(ScoundManager.Instance.ghostEntry);
        }    
    }

}
