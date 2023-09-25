using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SystemTestTextControl : MonoBehaviour
{
    float timer = 0;

    public GameObject backGround;

    public static bool isTimer = false;

    void FixedUpdate()
    {
        timer += 1 * Time.deltaTime;
        
        if (isTimer)
        {
            backGround.SetActive(true);
            timer = 0;
            if (timer > 2f)
            {
                backGround.SetActive(false);
            }
            isTimer = false;
        }
    }
}
