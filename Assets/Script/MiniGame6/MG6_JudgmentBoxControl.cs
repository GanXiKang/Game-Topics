using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MG6_JudgmentBoxControl : MonoBehaviour
{
    public Image left;
    public Image right;

    int j = 1;

    void Update()
    {
        switch (j)
        {
            case 1:
                left.rectTransform.anchoredPosition = new Vector3(-200, 370, 0);
                right.rectTransform.anchoredPosition = new Vector3(200, 370, 0);
                break;

            case 2:
                left.rectTransform.anchoredPosition = new Vector3(-100, 370, 0);
                right.rectTransform.anchoredPosition = new Vector3(100, 370, 0);
                break;

        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            j++;
            print(j);
        }
    }
}
