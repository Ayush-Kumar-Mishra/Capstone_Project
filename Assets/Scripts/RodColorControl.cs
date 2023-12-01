using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RodColorControl : MonoBehaviour
{
    public Animator colorChangeAnim;

    private void Start()
    {
        colorChangeAnim.speed = 0f;
    }
    void Update()
    {
        StartCoroutine(ColorChange());
    }

    IEnumerator ColorChange()
    {
        yield return new WaitForSeconds(4f);
        colorChangeAnim.speed = 0.2f;
    }
}
