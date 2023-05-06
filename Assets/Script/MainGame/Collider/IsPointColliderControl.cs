using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsPointColliderControl : MonoBehaviour
{
    public GameObject Interactive_UI;
    public int pointNum;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "P1" && Dice.P1_totalNum == pointNum)
        {
            StartCoroutine(NextPlayer());
        }
        if (other.tag == "P2" && Dice.P2_totalNum == pointNum)
        {
            StartCoroutine(NextPlayer());
        }
        if (other.tag == "P3" && Dice.P3_totalNum == pointNum)
        {
            StartCoroutine(NextPlayer());
        }
        if (other.tag == "P4" && Dice.P4_totalNum == pointNum)
        {
            StartCoroutine(NextPlayer());
        }
    }
    IEnumerator NextPlayer()
    {
        yield return new WaitForSeconds(3f);
        Interactive_UI.SetActive(true);
        CameraControl.changeCamera++;
    }
}

