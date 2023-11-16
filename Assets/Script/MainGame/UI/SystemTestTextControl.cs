using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SystemTestTextControl : MonoBehaviour
{
    float timer = 0;

    public GameObject backGround;
    public Text systemText;

    public static bool isTimer = false;

    void FixedUpdate()
    {
        timer += 1 * Time.deltaTime;
        if (timer > 2f)
        {
            backGround.SetActive(false);
            systemText.fontSize = 18;
        }

        if (isTimer)
        {
            backGround.SetActive(true);
            timer = 0;
            isTimer = false;
        }
    }
}
