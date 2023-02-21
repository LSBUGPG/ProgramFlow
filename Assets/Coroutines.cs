using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coroutines : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(Count());
    }

    void Update()
    {
    }

    IEnumerator Count()
    {
        int count = 0;
        while (true)
        {
            yield return new WaitForSeconds(1);
            count++;
            Debug.Log($"{count}");
        }
    }
}
