using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Arr_Movement_In_Per : MonoBehaviour
{
    public GameObject arrow1;
    public GameObject arrow2;
    public GameObject arrow3;
    public GameObject questionImage;
    public GameObject finalImage;
    public AudioSource questionAudio;
    public AudioSource periscopeExp;
    public AudioSource expAudio;

    void Start()
    {
        questionAudio.Play();
        StartCoroutine(ArrowMovement());
    }

    public void Restart() 
    {
        SceneManager.LoadScene(1);
    }

    IEnumerator ArrowMovement()
    {
        yield return new WaitForSeconds(3f);
        questionImage.SetActive(false);
        arrow1.SetActive(true);
        periscopeExp.Play();
        yield return new WaitForSeconds(5f);
        Destroy(arrow1.gameObject);
        arrow2.SetActive(true);
        yield return new WaitForSeconds(5f);
        Destroy(arrow2.gameObject);
        arrow3.SetActive(true);
        expAudio.Play();
        yield return new WaitForSeconds(5f);
        Destroy(arrow3.gameObject);
        yield return new WaitForSeconds(8f);
        finalImage.SetActive(true);
    }
}
