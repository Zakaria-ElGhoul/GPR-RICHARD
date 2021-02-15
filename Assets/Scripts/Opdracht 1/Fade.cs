using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fade : MonoBehaviour
{
    [SerializeField] float time;
    [SerializeField] Renderer rend;
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            StartCoroutine("FadeOut");
        }
    }

    IEnumerator FadeOut()
    {
        Debug.Log("Ik start nu de coroutine");

        for (float time = 1f; time >= 0; time -= 0.1f)
        {
            Color c = rend.material.color;
            c.a = time;
            rend.material.color = c;
            Debug.Log("coroutine update");
            yield return new WaitForSeconds(0.1f);
        }

        Debug.Log("Coroutine Einde");
    }

    IEnumerator TestCoroutine()
    {
        Debug.Log("Ik start nu de coroutine");
        yield return new WaitForSeconds(0.5f);
        Debug.Log("coroutine update");
        yield return new WaitForSeconds(0.5f);
        Debug.Log("Coroutine Einde");
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
