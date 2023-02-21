using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Updater : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log($"{name}.Start()");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log($"{name}.Update()");
    }
}
