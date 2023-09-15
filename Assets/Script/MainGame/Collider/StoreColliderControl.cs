using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoreColliderControl : MonoBehaviour
{
    public static int who;

    public int pointNum;
    public Transform target, buying;

    int Trans;

    private void OnTriggerEnter(Collider other)
    {
        if (!PropsControl.isTrans)
        {
            if (other.tag == "P1")
            {
                if (DiceControl.P1_totalNum == pointNum)
                {
                    who = 1;
                    AnimatorControl.isP1Move = false;
                    StartCoroutine(LookTarget());
                }
            }
            else if (other.tag == "P2")
            {
                if (DiceControl.P2_totalNum == pointNum)
                {
                    who = 2;
                    AnimatorControl.isP2Move = false;
                    StartCoroutine(LookTarget());
                }
            }
            else if (other.tag == "P3")
            {
                if (DiceControl.P3_totalNum == pointNum)
                {
                    who = 3;
                    AnimatorControl.isP3Move = false;
                    StartCoroutine(LookTarget());
                }
            }
            else if (other.tag == "P4")
            {
                if (DiceControl.P4_totalNum == pointNum)
                {
                    who = 4;
                    AnimatorControl.isP4Move = false;
                    StartCoroutine(LookTarget());
                }
            }
        }
        else
        {
            Trans++;
            if (Trans == 2)
            {
                PropsControl.isTrans = false;
            }
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

    IEnumerator LookTarget()
    {
        yield return new WaitForSeconds(1f);
        PlayerMoveControl.isMove = false;
        StoreUIControl.isStore = true;
    }
}

