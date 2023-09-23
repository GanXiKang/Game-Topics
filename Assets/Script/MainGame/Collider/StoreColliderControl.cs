using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoreColliderControl : MonoBehaviour
{
    public static bool P1_EnterStore = true, P2_EnterStore = true, P3_EnterStore = true, P4_EnterStore = true;
    public static int who;

    public int pointNum;
    public Transform target, buying;

    private void OnTriggerEnter(Collider other)
    {
        if (!PropsControl.isTrans)
        {
            if (other.tag == "P1" && P1_EnterStore)
            {
                if (DiceControl.P1_totalNum == pointNum)
                {
                    who = 1;
                    P1_EnterStore = false;
                    AnimatorControl.isP1Move = false;
                    StartCoroutine(LookTarget());
                    if (Menu_ChoosePlayer.whyP1 == 1)
                    {
                        PowerUIControl.isMouseCanUsePower =true;
                    }
                }
            }
            else if (other.tag == "P2" && P2_EnterStore)
            {
                if (DiceControl.P2_totalNum == pointNum)
                {
                    who = 2;
                    P2_EnterStore = false;
                    AnimatorControl.isP2Move = false;
                    StartCoroutine(LookTarget());
                    if (Menu_ChoosePlayer.whyP2 == 1)
                    {
                        PowerUIControl.isMouseCanUsePower = true;
                    }
                }
            }
            else if (other.tag == "P3" && P3_EnterStore)
            {
                if (DiceControl.P3_totalNum == pointNum)
                {
                    who = 3;
                    P3_EnterStore = false;
                    AnimatorControl.isP3Move = false;
                    StartCoroutine(LookTarget());
                    if (Menu_ChoosePlayer.whyP3 == 1)
                    {
                        PowerUIControl.isMouseCanUsePower = true;
                    }
                }
            }
            else if (other.tag == "P4" && P4_EnterStore)
            {
                if (DiceControl.P4_totalNum == pointNum)
                {
                    who = 4;
                    P4_EnterStore = false;
                    AnimatorControl.isP4Move = false;
                    StartCoroutine(LookTarget());
                    if (Menu_ChoosePlayer.whyP4 == 1)
                    {
                        PowerUIControl.isMouseCanUsePower = true;
                    }
                }
            }
        }
        else
        {
            StartCoroutine(Transposition());
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "P1")
        {
            if (DiceControl.P1_totalNum == pointNum)
            {
                if (!PlayerMoveControl.isMove)
                {
                    if (StoreUIControl.isStore)
                    {
                        Vector3 targetDirection = target.position - other.transform.position;
                        Quaternion targetRotation = Quaternion.LookRotation(targetDirection);
                        other.transform.rotation = Quaternion.Lerp(other.transform.rotation, targetRotation, 5f * Time.deltaTime);
                    }
                    if (StoreUIControl.isBuying)
                    {
                        Vector3 buyingDirection = buying.position - other.transform.position;
                        Quaternion buyingRotation = Quaternion.LookRotation(buyingDirection);
                        other.transform.rotation = Quaternion.Lerp(other.transform.rotation, buyingRotation, 5f * Time.deltaTime);
                    }
                }
            }
        }
        else if (other.tag == "P2")
        {
            if (DiceControl.P2_totalNum == pointNum)
            {
                if (!PlayerMoveControl.isMove)
                {
                    if (!StoreUIControl.isBuying)
                    {
                        Vector3 targetDirection = target.position - other.transform.position;
                        Quaternion targetRotation = Quaternion.LookRotation(targetDirection);
                        other.transform.rotation = Quaternion.Lerp(other.transform.rotation, targetRotation, 5f * Time.deltaTime);
                    }
                    else
                    {
                        Vector3 buyingDirection = buying.position - other.transform.position;
                        Quaternion buyingRotation = Quaternion.LookRotation(buyingDirection);
                        other.transform.rotation = Quaternion.Lerp(other.transform.rotation, buyingRotation, 5f * Time.deltaTime);
                    }
                }
            }
        }
        else if (other.tag == "P3")
        {
            if (DiceControl.P3_totalNum == pointNum)
            {
                if (!PlayerMoveControl.isMove)
                {
                    if (!StoreUIControl.isBuying)
                    {
                        Vector3 targetDirection = target.position - other.transform.position;
                        Quaternion targetRotation = Quaternion.LookRotation(targetDirection);
                        other.transform.rotation = Quaternion.Lerp(other.transform.rotation, targetRotation, 5f * Time.deltaTime);
                    }
                    else
                    {
                        Vector3 buyingDirection = buying.position - other.transform.position;
                        Quaternion buyingRotation = Quaternion.LookRotation(buyingDirection);
                        other.transform.rotation = Quaternion.Lerp(other.transform.rotation, buyingRotation, 5f * Time.deltaTime);
                    }
                }
            }
        }
        else if (other.tag == "P4")
        {
            if (DiceControl.P4_totalNum == pointNum)
            {
                if (!PlayerMoveControl.isMove)
                {
                    if (!StoreUIControl.isBuying)
                    {
                        Vector3 targetDirection = target.position - other.transform.position;
                        Quaternion targetRotation = Quaternion.LookRotation(targetDirection);
                        other.transform.rotation = Quaternion.Lerp(other.transform.rotation, targetRotation, 5f * Time.deltaTime);
                    }
                    else
                    {
                        Vector3 buyingDirection = buying.position - other.transform.position;
                        Quaternion buyingRotation = Quaternion.LookRotation(buyingDirection);
                        other.transform.rotation = Quaternion.Lerp(other.transform.rotation, buyingRotation, 5f * Time.deltaTime);
                    }
                }
            }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "P1")
        {
            P1_EnterStore = true;
        }
        if (other.tag == "P2")
        {
            P2_EnterStore = true;
        }
        if (other.tag == "P3")
        {
            P3_EnterStore = true;
        }
        if (other.tag == "P4")
        {
            P4_EnterStore = true;
        }
    }

    IEnumerator LookTarget()
    {
        yield return new WaitForSeconds(1f);
        PlayerMoveControl.isMove = false;
        StoreUIControl.isStore = true;
    }
    IEnumerator Transposition()
    {
        yield return new WaitForSeconds(1f);
        PropsControl.isTrans = false;
    }
}

