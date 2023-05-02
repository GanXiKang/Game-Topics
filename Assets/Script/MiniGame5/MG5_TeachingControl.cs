using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MG5_TeachingControl : MonoBehaviour
{
    public GameObject TeachGroup,teach, mouse1, mouse2, mouse3;
    void Start()
    {
        StartCoroutine(CloseTeach());
    }
    void Update()
    {
        if (MG5_UIControl.isStart)
        {
            if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.RightArrow))
            {
                teach.SetActive(false);
            }
        }
    }
    IEnumerator CloseTeach()
    {

        yield return new WaitForSeconds(0.5f);
        mouse1.SetActive(false);
        mouse2.SetActive(true);
        mouse3.SetActive(false);
        yield return new WaitForSeconds(0.5f);
        mouse1.SetActive(false);
        mouse2.SetActive(false);
        mouse3.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        mouse1.SetActive(true);
        mouse2.SetActive(false);
        mouse3.SetActive(false);
        yield return new WaitForSeconds(0.5f);
        mouse1.SetActive(false);
        mouse2.SetActive(true);
        mouse3.SetActive(false);
        yield return new WaitForSeconds(0.5f);
        mouse1.SetActive(false);
        mouse2.SetActive(false);
        mouse3.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        TeachGroup.SetActive(false);
    }
}
