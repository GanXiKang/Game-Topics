using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MG3_ButtonControl : MonoBehaviour
{
    public GameObject B_Start;
    public GameObject B_Box1;
    public GameObject B_Box2;
    public GameObject B_Box3;
    public void StartControl()
    {
        B_Start.gameObject.SetActive(false);
        MG3_BoxMoveControl.PlayGameNum++;
    }
    public void OpenBox1()
    {
        
    }
    public void OpenBox2()
    {

    }
    public void OpenBox3()
    {

    }
}
