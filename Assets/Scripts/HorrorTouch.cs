using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorrorTouch : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        ScoundManager.Instance.PlaySound(ScoundManager.Instance.girlHumming);
    }
}



