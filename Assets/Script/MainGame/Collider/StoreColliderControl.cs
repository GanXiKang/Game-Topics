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
                AnimatorControl.isP1Move = false;
                StartCoroutine(LookTarget());
            }
        }
        else if (other.tag == "P2")
        {
            if (DiceControl.P2_totalNum == pointNum)
            {
                AnimatorControl.isP2Move = false;
                
            }
        }
        else if (other.tag == "P3")
        {
            if (DiceControl.P3_totalNum == pointNum)
            {
                AnimatorControl.isP3Move = false;
                
            }
        }
        else if (other.tag == "P4")
        {
            if (DiceControl.P4_totalNum == pointNum)
            {
                AnimatorControl.isP4Move = false;
                
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
                    Vector3 targetDirection = target.position - other.transform.position;
                    Quaternion targetRotation = Quaternion.LookRotation(targetDirection);
                    other.transform.rotation = Quaternion.Lerp(other.transform.rotation, targetRotation, 5f * Time.deltaTime);
                }
            }
        }
    }

    IEnumerator LookTarget()
    {
        print("start");
        yield return new WaitForSeconds(10f);
        print("finish");
        PlayerMoveControl.isMove = false;
    }
}

