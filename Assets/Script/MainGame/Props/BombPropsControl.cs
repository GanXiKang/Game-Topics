using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombPropsControl : MonoBehaviour
{
    AudioSource boom;
    Rigidbody rb;

    public static int pointNum;
    public static bool iscolliderBombText = false;

    bool r = true, once = true;

    void Start()
    {
        boom = GetComponent<AudioSource>();
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        if (r)
        {
            transform.Rotate(0, 1, 0);
        }
    }

    private void OnTriggerStay(Collider other)
    {
        switch (ChangeCameraControl.changeCameraNum)
        {
            case 1:
                if (other.tag == "P1")
                {
                    if (!InsBombControl.isP1InsBomb)
                    {
                        if (DiceControl.P1_totalNum == pointNum)
                        {
                            if (!AnimalsPowerControl.chickenUsePower || Menu_ChoosePlayer.whyP1 != 10)
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
                            else
                            {
                                Destroy(this.gameObject);
                            }
                        }
                    }
                    else
                    {
                        InsBombControl.isP1InsBomb = false;
                    }
                }
                break;

            case 2:
                if (other.tag == "P2")
                {
                    if (!InsBombControl.isP2InsBomb)
                    {
                        if (DiceControl.P2_totalNum == pointNum)
                        {
                            if (once)
                            {
                                if (!AnimalsPowerControl.chickenUsePower || Menu_ChoosePlayer.whyP2 != 10)
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
                                else
                                {
                                    Destroy(this.gameObject);
                                }
                                once = false;
                            }
                        }
                    }
                    else
                    {
                        InsBombControl.isP2InsBomb = false;
                    }
                }
                break;

            case 3:
                if (other.tag == "P3")
                {
                    if (!InsBombControl.isP3InsBomb)
                    {
                        if (DiceControl.P3_totalNum == pointNum)
                        {
                            if (!AnimalsPowerControl.chickenUsePower || Menu_ChoosePlayer.whyP3 != 10)
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
                            else
                            {
                                Destroy(this.gameObject);
                            }
                        }
                    }
                    else
                    {
                        InsBombControl.isP3InsBomb = false;
                    }
                }
                break;

            case 4:
                if (other.tag == "P4")
                {
                    if (!InsBombControl.isP4InsBomb)
                    {
                        if (DiceControl.P4_totalNum == pointNum)
                        {
                            if (!AnimalsPowerControl.chickenUsePower || Menu_ChoosePlayer.whyP4 != 10)
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
                            else
                            {
                                Destroy(this.gameObject);
                            }
                        }
                    }
                    else
                    {
                        InsBombControl.isP4InsBomb = false;
                    }
                }
                break;
        }
    }

    IEnumerator StopTiming()
    {
        r = false;
        rb.isKinematic = false;
        boom.Play();
        iscolliderBombText = true;
        yield return new WaitForSeconds(4f);
        IsStopUIControl.isBombStopUI++;
        Destroy(this.gameObject);
        once = true;
    }
}
