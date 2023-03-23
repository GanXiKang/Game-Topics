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
        B_Box1.gameObject.SetActive(true);
        B_Box2.gameObject.SetActive(true);
        B_Box3.gameObject.SetActive(true);
        MG3_BoxMoveControl.PlayGameNum++;
        MG3_StarControl.insStar = true;
    }
    public void OpenBox1()
    {
        MG3_BoxMoveControl.openBox1 = true;
    }
    public void OpenBox2()
    {
        MG3_BoxMoveControl.openBox2 = true;
    }
    public void OpenBox3()
    {
        MG3_BoxMoveControl.openBox3 = true;
    }
}
