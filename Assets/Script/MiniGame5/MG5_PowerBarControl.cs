using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MG5_PowerBarControl : MonoBehaviour
{
    public GameObject powerButton;
    public GameObject powerBar;
    public Image power;

    public static float value = 0;
    bool add = true;
    bool isButtonDown = false;

    public void ButtonDown()
    {
        isButtonDown = true;
    }
    public void ButtonUp()
    {
        isButtonDown = false;
        StartCoroutine(ChangeCamera());
    }
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
        if (isButtonDown == true)
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

    IEnumerator ChangeCamera()
    {
        yield return new WaitForSeconds(1.5f);
        MG5_HookControl.math = true;
        MG5_CameraControl.watchPlayer = false;
        powerBar.SetActive(false);
        powerButton.SetActive(false);
    }
}

