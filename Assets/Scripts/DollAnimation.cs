using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DollAnimation : MonoBehaviour
{
    public Animator animator;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            UIManager.Instance.SetPromptText("You are going to die");

            ScoundManager.Instance.PlaySound(ScoundManager.Instance.going2Die);
            StartCoroutine(WaitForSceneLoad());


        }
    }

    private IEnumerator WaitForSceneLoad()
    {
        yield return new WaitForSeconds(5);
        SceneManager.LoadScene("MainMenu");

    }

}
