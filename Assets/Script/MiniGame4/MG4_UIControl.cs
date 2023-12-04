using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MG4_UIControl : MonoBehaviour
{
    AudioSource BGM;

    public AudioClip button, hit, jump;
    public GameObject startUI, doublePlaySpeed;
    public GameObject[] comboImage = new GameObject[10];

    public static bool isStart;

    bool jumpMusia = true;

    public void Button_Start()
    {
        startUI.SetActive(false);
        isStart = true;
        BGM.PlayOneShot(button);
    }

    void Start()
    {
        BGM = GetComponent<AudioSource>();
    }
    void Update()
    {
        combo();
        PlaySpeed();

        if (MG4_RoadBlockControl.hit)
        {
            BGM.PlayOneShot(hit);
            MG4_RoadBlockControl.hit = false;
        }
        if (!MG4_PlayerMoveControl.isJump && jumpMusia)
        {
            BGM.PlayOneShot(jump);
            jumpMusia = false;
        }
        if (MG4_PlayerMoveControl.isJump && !jumpMusia)
        {
            jumpMusia = true;
        }
    }

    void combo()
    {
        if (MG4_RoadBlockControl.combo == 3)
        {
            comboImage[0].SetActive(true);
        }
        else if (MG4_RoadBlockControl.combo == 4)
        {
            comboImage[0].SetActive(false);
            comboImage[1].SetActive(true);
        }
        else if (MG4_RoadBlockControl.combo == 5)
        {
            comboImage[1].SetActive(false);
            comboImage[2].SetActive(true);
        }
        else if (MG4_RoadBlockControl.combo == 6)
        {
            comboImage[2].SetActive(false);
            comboImage[3].SetActive(true);
        }
        else if (MG4_RoadBlockControl.combo == 7)
        {
            comboImage[3].SetActive(false);
            comboImage[4].SetActive(true);
        }
        else if (MG4_RoadBlockControl.combo == 8)
        {
            comboImage[4].SetActive(false);
            comboImage[5].SetActive(true);
        }
        else if (MG4_RoadBlockControl.combo == 9)
        {
            comboImage[5].SetActive(false);
            comboImage[6].SetActive(true);
        }
        else if (MG4_RoadBlockControl.combo == 10)
        {
            comboImage[6].SetActive(false);
            comboImage[7].SetActive(true);
        }
        else if (MG4_RoadBlockControl.combo == 11)
        {
            comboImage[7].SetActive(false);
            comboImage[8].SetActive(true);
        }
        else if (MG4_RoadBlockControl.combo == 12)
        {
            comboImage[8].SetActive(false);
            comboImage[9].SetActive(true);
        }
        else if (MG4_RoadBlockControl.combo == 0)
        {
            for (int i = 0; i < 10; i++)
            {
                comboImage[i].SetActive(false);
            }
        }
    }
    void PlaySpeed()
    {
        if (UI_StopGameControl.isDoublePlaySpeed)
        {
            doublePlaySpeed.SetActive(true);
        }
        else
        {
            doublePlaySpeed.SetActive(false);
        }
    }
}
