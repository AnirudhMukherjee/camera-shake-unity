using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class explosionTrigger : MonoBehaviour
{

    public Shaker sk;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) {
            StartCoroutine(sk.Shake(.15f, .4f));
        }
    }
}
