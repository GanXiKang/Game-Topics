using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MG6_BalanceBarControl : MonoBehaviour
{
    public Image power;

    float value = 0;
    bool isAdd = false;
    void Update()
    {
        if (value <= 0)
        {
            value = 0;
        }
        if (value >= 8)
        {
            value = 8;
        }
        if (Input.GetMouseButton(0))
        {
            isAdd = true;
        }
        if (Input.GetMouseButtonUp(0))
        {
            isAdd = false;
        }
        power.rectTransform.localScale = new Vector3(value, 0.5f, 1);
    }
    void FixedUpdate()
    {
        if (isAdd == true)
        {
            value += 0.5f;
        }
        else
        {
            value -= 1f;
        }
    }
}
