using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MG1_StartButtonControl : MonoBehaviour
{
    public GameObject startUI;

    public void Button_Start()
    {
        startUI.SetActive(false);
    }
}
