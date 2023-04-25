using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Menu_LightControl : MonoBehaviour
{
    public Image lightGroup;
    void Update()
    {
        if (Menu_ChoosePlayer.chooseP == 1)
        {
            lightGroup.rectTransform.anchoredPosition = new Vector3(-600, 0, 0);
        }
        if (Menu_ChoosePlayer.chooseP == 2)
        {
            lightGroup.rectTransform.anchoredPosition = new Vector3(-200, 0, 0);
        }
        if (Menu_ChoosePlayer.chooseP == 3)
        {
            lightGroup.rectTransform.anchoredPosition = new Vector3(200, 0, 0);
        }
        if (Menu_ChoosePlayer.chooseP == 4)
        {
            lightGroup.rectTransform.anchoredPosition = new Vector3(600, 0, 0);
        }
    }
}
