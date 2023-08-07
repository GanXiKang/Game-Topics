using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoreColliderControl : MonoBehaviour
{
    public int pointNum;
    public GameObject storeManager;

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
                other.transform.rotation = Quaternion.Lerp(other.transform.rotation, storeManager.transform.rotation, 2f * Time.deltaTime);
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
}
