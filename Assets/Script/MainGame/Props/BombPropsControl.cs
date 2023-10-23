using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombPropsControl : MonoBehaviour
{
    AudioSource boom;

    public static int pointNum;
    public static bool iscolliderBombText = false;

    bool r = true;

    void Start()
    {
        boom = GetComponent<AudioSource>();
    }
    void FixedUpdate()
    {
        if (r)
        {
            transform.Rotate(0, 1, 0);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "P1")
        {
            if (!InsBombControl.isP1InsBomb)
            {
                if (DiceControl.P1_totalNum == pointNum)
                {
                    AnimatorControl.isP1Dizziness = true;
                    IsStopUIControl.isBombStopP1 = true;
                    StartCoroutine(StopTiming());
                    if (AnimalsPowerControl.dragonUsePower && Menu_ChoosePlayer.whyP1 == 5)
                    {
                        AnimalsPowerControl.dragonUsePower = false;
                        AnimatorControl.isP1Skill = false;
                    }
                }
            }
            else 
            {
                InsBombControl.isP1InsBomb = false;
            }
        }
        else if (other.tag == "P2")
        {
            if (!InsBombControl.isP2InsBomb)
            {
                if (DiceControl.P2_totalNum == pointNum)
                {
                    AnimatorControl.isP2Dizziness = true;
                    IsStopUIControl.isBombStopP2 = true;
                    StartCoroutine(StopTiming());
                    if (AnimalsPowerControl.dragonUsePower && Menu_ChoosePlayer.whyP2 == 5)
                    {
                        AnimalsPowerControl.dragonUsePower = false;
                        AnimatorControl.isP2Skill = false;
                    }
                }
            }
            else
            {
                InsBombControl.isP2InsBomb = false;
            }
        }
        else if (other.tag == "P3")
        {
            if (!InsBombControl.isP3InsBomb)
            {
                if (DiceControl.P3_totalNum == pointNum)
                {
                    AnimatorControl.isP3Dizziness = true;
                    IsStopUIControl.isBombStopP3 = true;
                    StartCoroutine(StopTiming());
                    if (AnimalsPowerControl.dragonUsePower && Menu_ChoosePlayer.whyP3 == 5)
                    {
                        AnimalsPowerControl.dragonUsePower = false;
                        AnimatorControl.isP3Skill = false;
                    }
                }
            }
            else
            {
                InsBombControl.isP3InsBomb = false;
            }
        }
        else if (other.tag == "P4")
        {
            if (!InsBombControl.isP4InsBomb)
            {
                if (DiceControl.P4_totalNum == pointNum)
                {
                    AnimatorControl.isP4Dizziness = true;
                    IsStopUIControl.isBombStopP4 = true;
                    StartCoroutine(StopTiming());
                    if (AnimalsPowerControl.dragonUsePower && Menu_ChoosePlayer.whyP4 == 5)
                    {
                        AnimalsPowerControl.dragonUsePower = false;
                        AnimatorControl.isP4Skill = false;
                    }
                }
            }
            else
            {
                InsBombControl.isP4InsBomb = false;
            }
        }
    }
    IEnumerator StopTiming()
    {
        r = false;
        boom.Play();
        iscolliderBombText = true;
        yield return new WaitForSeconds(3f);
        IsStopUIControl.isBombStopUI++;
        Destroy(this.gameObject);  
    }
}
