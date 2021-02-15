using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coroutines : MonoBehaviour
{
    void Update()
    { 
        if(Input.GetKey(KeyCode.Space))
        {
            StartCoroutine(Lerp(1, new Vector3(1,1,1)));
        }
    }

    IEnumerator Lerp(float time, Vector3 t)
    {
        float elapsedTime = 0; 

        while(elapsedTime < 1)
        {

        elapsedTime += Time.deltaTime;

        transform.position = Vector3.Lerp(transform.position, t, (elapsedTime / time));

        }
        yield return null;
    }
}
