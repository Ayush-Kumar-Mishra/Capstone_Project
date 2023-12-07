using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AnimationManager : MonoBehaviour
{
    public GameObject animationObj;
    public GameObject questionScreen;
    public AudioSource condAudio;

    private void Start()
    {
        StartCoroutine(StartAnim());    
    }

    IEnumerator StartAnim()
    {
        yield return new WaitForSeconds(42f);
        questionScreen.SetActive(false);
        animationObj.SetActive(true);
        yield return new WaitForSeconds(5f);
        condAudio.Play();
    }

    public void Restart()
    {
        SceneManager.LoadScene(0);
    }
}
