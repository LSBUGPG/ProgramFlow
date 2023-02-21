using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Invoker : MonoBehaviour
{
    void Start()
    {
    }

    void Update()
    {
        Invoke("HelloWorld", 5f);
    }

    void HelloWorld()
    {
        Debug.Log("Hello World");
    }
}
