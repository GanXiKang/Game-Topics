using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SystemTestTextControl : MonoBehaviour
{
    float timer = 0;
    public Text systemText;
    void FixedUpdate()
    {
        timer += 1 * Time.deltaTime;
        if (timer > 3)
        {
            systemText.text = " ";
            timer = 0;
        }
    }
}
