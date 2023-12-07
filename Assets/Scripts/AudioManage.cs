using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManage : MonoBehaviour
{
    public AudioSource questionAudio;
 
    void Start()
    {
        StartCoroutine(AudioRest());
    }

    IEnumerator AudioRest()
    {
        yield return new WaitForSeconds(3f);
        questionAudio.Play();
    }
}
