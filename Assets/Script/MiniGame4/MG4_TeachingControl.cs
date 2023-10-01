using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MG4_TeachingControl : MonoBehaviour
{
    public GameObject teach, space1, space2;

    bool isTeach = true;
    void Update()
    {
        if (MG4_UIControl.isStart)
        {
            if (isTeach)
            {
                StartCoroutine(CloseTeach());
            }
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            teach.SetActive(false);
        }
    }
    IEnumerator CloseTeach()
    {
        isTeach = false;
        yield return new WaitForSeconds(0.5f);
        space1.SetActive(false);
        space2.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        space1.SetActive(true);
        space2.SetActive(false);
        yield return new WaitForSeconds(0.5f);
        space1.SetActive(false);
        space2.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        space1.SetActive(true);
        space2.SetActive(false);
        yield return new WaitForSeconds(0.5f);
        space1.SetActive(false);
        space2.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        teach.SetActive(false);
    }
}
