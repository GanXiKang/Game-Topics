using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MG5_PowerBarControl : MonoBehaviour
{
    public GameObject powerBar;
    public Image power;

    public static float value = 0;
    bool add = true;

    void Update()
    {
        if (value >= 5)
        {
            add = false;
            value = 5;
        }
        if (value <= 0)
        {
            add = true;
            value = 0;
        }
        power.rectTransform.localScale = new Vector3(1, value, 1);
    }
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            if (add == true)
            {
                value += 0.1f;
            }
            else
            {
                value -= 0.1f;
            }

        }
    }
}
