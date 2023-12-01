using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaxDrop : MonoBehaviour
{
    public GameObject waxDropObject;
    public Animator waxDrop1;

    void Start()
    {
        waxDrop1.speed = 0f;
    }

    void Update()
    {
        StartCoroutine(WaxDropTime());
    }
    IEnumerator WaxDropTime()
    {
        yield return new WaitForSeconds(5f);
        waxDrop1.speed = 0.5f;
        yield return new WaitForSeconds(2f);
        waxDropObject.SetActive(false);
    }
}
