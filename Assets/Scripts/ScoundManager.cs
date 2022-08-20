using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoundManager : MonoBehaviour
{
    private static ScoundManager _instance;
    public static ScoundManager Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = GameObject.FindObjectOfType<ScoundManager>();
            }
            return _instance;
        }
    }

    public AudioClip ghostEntry;
    public AudioClip ghostEntry2;
    public AudioClip doorOpen;
    public AudioClip doorClose;
    public AudioClip whistle;
    public AudioClip girlHumming;
    public AudioClip going2Die;

    public void PlaySound(AudioClip clipName)
    {
        AudioSource.PlayClipAtPoint(clipName, Camera.main.transform.position);
    }

}
