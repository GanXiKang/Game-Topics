using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoreColliderControl : MonoBehaviour
{
    public int pointNum;
    public Transform target;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "P1")
        {
            if (DiceControl.P1_totalNum == pointNum)
            {
                StartCoroutine(LookTarget());
            }
        }
        else if (other.tag == "P2")
        {
            if (DiceControl.P2_totalNum == pointNum)
            {
                StartCoroutine(LookTarget());
            }
        }
        else if (other.tag == "P3")
        {
            if (DiceControl.P3_totalNum == pointNum)
            {
                StartCoroutine(LookTarget());
            }
        }
        else if (other.tag == "P4")
        {
            if (DiceControl.P4_totalNum == pointNum)
            {
                StartCoroutine(LookTarget());
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
                    AnimatorControl.isP1Move = false;

                    Vector3 targetDirection = target.position - other.transform.position;
                    Quaternion targetRotation = Quaternion.LookRotation(targetDirection);
                    other.transform.rotation = Quaternion.Lerp(other.transform.rotation, targetRotation, 5f * Time.deltaTime);
                }
            }
        }
        else if (other.tag == "P2")
        {
            if (DiceControl.P2_totalNum == pointNum)
            {
                if (!PlayerMoveControl.isMove)
                {
                    AnimatorControl.isP2Move = false;

                    Vector3 targetDirection = target.position - other.transform.position;
                    Quaternion targetRotation = Quaternion.LookRotation(targetDirection);
                    other.transform.rotation = Quaternion.Lerp(other.transform.rotation, targetRotation, 5f * Time.deltaTime);
                }
            }
        }
        else if (other.tag == "P3")
        {
            if (DiceControl.P3_totalNum == pointNum)
            {
                if (!PlayerMoveControl.isMove)
                {
                    AnimatorControl.isP3Move = false;

                    Vector3 targetDirection = target.position - other.transform.position;
                    Quaternion targetRotation = Quaternion.LookRotation(targetDirection);
                    other.transform.rotation = Quaternion.Lerp(other.transform.rotation, targetRotation, 5f * Time.deltaTime);
                }
            }
        }
        else if (other.tag == "P4")
        {
            if (DiceControl.P4_totalNum == pointNum)
            {
                if (!PlayerMoveControl.isMove)
                {
                    AnimatorControl.isP4Move = false;

                    Vector3 targetDirection = target.position - other.transform.position;
                    Quaternion targetRotation = Quaternion.LookRotation(targetDirection);
                    other.transform.rotation = Quaternion.Lerp(other.transform.rotation, targetRotation, 5f * Time.deltaTime);
                }
            }
        }
    }

    IEnumerator LookTarget()
    {
        yield return new WaitForSeconds(1f);
        PlayerMoveControl.isMove = false;
    }
}

