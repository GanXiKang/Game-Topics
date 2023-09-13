using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SystemTestTextControl : MonoBehaviour
{
    float timer = 0;
    public Text systemText;
    public static bool isTimer = false;
    void FixedUpdate()
    {
        if (isTimer)
        {
            timer += 1 * Time.deltaTime;
            if (timer > 2f)
            {
                systemText.text = " ";
                timer = 0;
                isTimer = false;
            }
        }
    }
}
