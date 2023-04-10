using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MG6_JudgmentBoxControl : MonoBehaviour
{
    public Image left;
    public Image right;

    public static int j = 1;

    void FixedUpdate()
    {
        switch (j)
        {
            case 1:
                left.rectTransform.anchoredPosition = new Vector3(-200, 370, 0);
                right.rectTransform.anchoredPosition = new Vector3(200, 370, 0);
                break;

            case 2:
                left.rectTransform.anchoredPosition = new Vector3(-300, 370, 0);
                right.rectTransform.anchoredPosition = new Vector3(50, 370, 0);
                break;

            case 3:
                left.rectTransform.anchoredPosition = new Vector3(100, 370, 0);
                right.rectTransform.anchoredPosition = new Vector3(400, 370, 0);
                break;

            case 4:
                left.rectTransform.anchoredPosition = new Vector3(-50, 370, 0);
                right.rectTransform.anchoredPosition = new Vector3(150, 370, 0);
                break;

            case 5:
                left.rectTransform.anchoredPosition = new Vector3(-350, 370, 0);
                right.rectTransform.anchoredPosition = new Vector3(-100, 370, 0);
                break;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "JudgmentBox")
        {
            j++;
        }
    }
}
