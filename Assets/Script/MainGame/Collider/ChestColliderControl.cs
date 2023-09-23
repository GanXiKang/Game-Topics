using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestColliderControl : MonoBehaviour
{
    public static bool P1_EnterBox = true, P2_EnterBox = true, P3_EnterBox = true, P4_EnterBox = true;
    public int boxPoint, isOpenNumber;
    public Transform target;

    public static int isOpen;

    bool isOpened = false;
    void OpenBoxJudge()
    {
        isOpen = isOpenNumber;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (!PropsControl.isTrans)
        {
            PowerUIControl.isMouseCanUsePower = true;
            print(PowerUIControl.isMouseCanUsePower);
            if (other.tag == "P1" && P1_EnterBox)
            {
                if (DiceControl.P1_totalNum == boxPoint)
                {
                    P1_EnterBox = false;
                    AnimatorControl.isP3Move = false;
                    StartCoroutine(ChangeCamera());
                }
            }
            else if (other.tag == "P2" && P2_EnterBox)
            {
                if (DiceControl.P2_totalNum == boxPoint)
                {
                    P2_EnterBox = false;
                    AnimatorControl.isP3Move = false;
                    StartCoroutine(ChangeCamera());
                }
            }
            else if (other.tag == "P3" && P3_EnterBox)
            {
                if (DiceControl.P3_totalNum == boxPoint)
                {
                    P3_EnterBox = false;
                    AnimatorControl.isP3Move = false;
                    StartCoroutine(ChangeCamera());
                }
            }
            else if (other.tag == "P4" && P4_EnterBox)
            {
                if (DiceControl.P4_totalNum == boxPoint)
                {
                    P4_EnterBox = false;
                    AnimatorControl.isP4Move = false;
                    StartCoroutine(ChangeCamera());
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
            if (DiceControl.P1_totalNum == boxPoint)
            {
                if (!PlayerMoveControl.isMove)
                {
                    Vector3 targetDirection = target.position - other.transform.position;
                    Quaternion targetRotation = Quaternion.LookRotation(targetDirection);
                    other.transform.rotation = Quaternion.Lerp(other.transform.rotation, targetRotation, 5f * Time.deltaTime);
                }
            }
        }
        else if (other.tag == "P2")
        {
            if (DiceControl.P2_totalNum == boxPoint)
            {
                if (!PlayerMoveControl.isMove)
                {
                    Vector3 targetDirection = target.position - other.transform.position;
                    Quaternion targetRotation = Quaternion.LookRotation(targetDirection);
                    other.transform.rotation = Quaternion.Lerp(other.transform.rotation, targetRotation, 5f * Time.deltaTime);
                }
            }
        }
        else if (other.tag == "P3")
        {
            if (DiceControl.P3_totalNum == boxPoint)
            {
                if (!PlayerMoveControl.isMove)
                {
                    Vector3 targetDirection = target.position - other.transform.position;
                    Quaternion targetRotation = Quaternion.LookRotation(targetDirection);
                    other.transform.rotation = Quaternion.Lerp(other.transform.rotation, targetRotation, 5f * Time.deltaTime);
                }
            }
        }
        else if (other.tag == "P4")
        {
            if (DiceControl.P4_totalNum == boxPoint)
            {
                if (!PlayerMoveControl.isMove)
                {
                    Vector3 targetDirection = target.position - other.transform.position;
                    Quaternion targetRotation = Quaternion.LookRotation(targetDirection);
                    other.transform.rotation = Quaternion.Lerp(other.transform.rotation, targetRotation, 5f * Time.deltaTime);
                }
            }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "P1")
        {
            P1_EnterBox = true;
        }
        if (other.tag == "P2")
        {
            P2_EnterBox = true;
        }
        if (other.tag == "P3")
        {
            P3_EnterBox = true;
        }
        if (other.tag == "P4")
        {
            P4_EnterBox = true;
        }
    }
    IEnumerator ChangeCamera()
    {
        yield return new WaitForSeconds(1f);
        if (!isOpened)
        {
            PlayerMoveControl.isMove = false;
            yield return new WaitForSeconds(1f);
            OpenBoxJudge();
            yield return new WaitForSeconds(1f);
        }
        yield return new WaitForSeconds(1f);
        ChangeCameraControl.changeCameraNum++;
        DiceUIControl.isDiceUI = true;
        isOpened = true;
    }
    IEnumerator Transposition()
    {
        yield return new WaitForSeconds(1f);
        PropsControl.isTrans = false;
    }
}
