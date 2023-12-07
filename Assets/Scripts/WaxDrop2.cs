using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class WaxDrop2 : MonoBehaviour
{
    public Animator waxDrop2;
    public GameObject[] waxCollected;
    void Start()
    {
        waxDrop2.speed = 0f;
    }

    void Update()
    {
        StartCoroutine(WaxDropTime2());
        StartCoroutine(WaxCollected());
    }
    IEnumerator WaxDropTime2()
    {
        yield return new WaitForSeconds(5f);
        waxDrop2.speed = 2f;
    }

    IEnumerator WaxCollected()
    {
        yield return new WaitForSeconds(5.5f);
        for (int i = 0;i < waxCollected.Length; i++)
        {
            waxCollected[i].SetActive(true);
            yield return new WaitForSeconds(0.4f);
        }
    }
}
