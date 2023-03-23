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

    public static float openWhyBox;
    public static float whyRound;

    public void StartControl()
    {
        whyRound++;
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
        openWhyBox = 1;
        B_Box1.gameObject.SetActive(false);
        B_Box2.gameObject.SetActive(false);
        B_Box3.gameObject.SetActive(false);
    }
    public void OpenBox2()
    {
        MG3_BoxMoveControl.openBox2 = true;
        openWhyBox = 2;
        B_Box1.gameObject.SetActive(false);
        B_Box2.gameObject.SetActive(false);
        B_Box3.gameObject.SetActive(false);
    }
    public void OpenBox3()
    {
        MG3_BoxMoveControl.openBox3 = true;
        openWhyBox = 3;
        B_Box1.gameObject.SetActive(false);
        B_Box2.gameObject.SetActive(false);
        B_Box3.gameObject.SetActive(false);
    }

}
