using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MG6_TeachingControl : MonoBehaviour
{
    public GameObject teach, mouse1, mouse2;

    bool isTeach = true;
    void Update()
    {
        if (MG6_UIControl.isStart)
        {
            if (isTeach)
            {
                StartCoroutine(CloseTeach());
            }
        }
    }
    IEnumerator CloseTeach()
    {
        isTeach = false;
        yield return new WaitForSeconds(0.5f);
        mouse1.SetActive(false);
        mouse2.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        mouse1.SetActive(true);
        mouse2.SetActive(false);
        yield return new WaitForSeconds(0.5f);
        mouse1.SetActive(false);
        mouse2.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        mouse1.SetActive(true);
        mouse2.SetActive(false);
        yield return new WaitForSeconds(0.5f);
        mouse1.SetActive(false);
        mouse2.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        teach.SetActive(false);
    }
}
