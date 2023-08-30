using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestColliderControl : MonoBehaviour
{
    public int boxPoint, isOpenNumber;
    public Transform target;

    public static int isOpen;

    void OpenBoxJudge()
    {
        isOpen = isOpenNumber;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "P1")
        {
            if (DiceControl.P1_totalNum == boxPoint)
            {
                AnimatorControl.isP1Move = false;
                StartCoroutine(ChangeCamera());
            }
        }
        else if (other.tag == "P2")
        {
            if (DiceControl.P2_totalNum == boxPoint)
            {
                AnimatorControl.isP2Move = false;
                StartCoroutine(ChangeCamera());
            }
        }
        else if (other.tag == "P3")
        {
            if (DiceControl.P3_totalNum == boxPoint)
            {
                AnimatorControl.isP3Move = false;
                StartCoroutine(ChangeCamera());
            }
        }
        else if (other.tag == "P4")
        {
            if (DiceControl.P4_totalNum == boxPoint)
            {
                AnimatorControl.isP4Move = false;
                StartCoroutine(ChangeCamera());
            }
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
    IEnumerator ChangeCamera()
    {
        yield return new WaitForSeconds(1f);
        PlayerMoveControl.isMove = false;
        yield return new WaitForSeconds(1f);
        OpenBoxJudge();
        yield return new WaitForSeconds(1f);
        ChangeCameraControl.changeCameraNum++;
        DiceUIControl.isDiceUI = true;
    }
}
