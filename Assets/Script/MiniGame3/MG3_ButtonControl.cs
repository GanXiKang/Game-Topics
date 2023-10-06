using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MG3_ButtonControl : MonoBehaviour
{ 
    public GameObject startUI, B_Next, B_Box1, B_Box2, B_Box3;
    public Text score;
    public AudioSource BGM;
    public AudioClip button, openCup, closeCup;

    public static bool downCup, openBox, destoryStar;
    public static float openWhyBox, round, destoryStarNum;

    bool startActive;

    public void Button_Start()
    {
        //BGM.PlayOneShot(button);
        //startUI.SetActive(false);
        //B_Box1.gameObject.SetActive(true);
        //B_Box2.gameObject.SetActive(true);
        //B_Box3.gameObject.SetActive(true);
        //MG3_StarControl.insStar = true;
        //downCup = true;
        //BGM.PlayOneShot(closeCup);
        //destoryStarNum++;
        //round++;
        //print("Round" + round);
    }
    public void NextRound()
    {
        //B_Next.gameObject.SetActive(false);
        //B_Box1.gameObject.SetActive(true);
        //B_Box2.gameObject.SetActive(true);
        //B_Box3.gameObject.SetActive(true);
        //MG3_StarControl.insStar = true;
        //downCup = true;
        //BGM.PlayOneShot(closeCup);
        //destoryStar = true;
        //destoryStarNum++;
        //round++;
        //print("Round" + round);
    }
    public void OpenWhyCup(int i)
    {
        //MG3_BoxMoveControl.openBox1 = true;
        openBox = true;
        openWhyBox = i;
        B_Box1.gameObject.SetActive(false);
        B_Box2.gameObject.SetActive(false);
        B_Box3.gameObject.SetActive(false);
        startActive = true;
        BGM.PlayOneShot(openCup);
    }
    
    void Update()
    {
        if (round <= 3)
        {
            if (startActive == true)
            {
                startActive = false;
                StartCoroutine(StartSetActice());
            }
            score.text = " " + MG3_StarControl.win;
        }
    }
    IEnumerator StartSetActice()
    {
        yield return new WaitForSeconds(2.5f);
        if (round < 3)
        {
            B_Next.gameObject.SetActive(true);
        }
    }
}
