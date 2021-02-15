using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForLoop : MonoBehaviour
{
    void Update()
    {
            StartCoroutine("ForLoopCoroutine");
    }

    IEnumerator ForLoopCoroutine()
    {
        Debug.Log("Ik start nu de coroutine");
        yield return new WaitForSeconds(0.5f);

        for (int i = 0; i < 10; i++)
        {
            Debug.Log("coroutine update");
        }

        Debug.Log("Coroutine Einde");
    }
}
