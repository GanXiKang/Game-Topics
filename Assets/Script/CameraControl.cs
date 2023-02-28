using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public GameObject Camera1, Camera2;

    void Update()
    {
        if (Dice.isThrow == true)
        {
            StartCoroutine(ChangeCamera());
        }
        else 
        {
            StopCoroutine(ChangeCamera());
        }
        
    }
    IEnumerator ChangeCamera()
    {
        Camera1.SetActive(false);
        Camera2.SetActive(true);
        yield return new WaitForSeconds(2f);
        Dice.isThrow = false;
        Camera1.SetActive(true);
        Camera2.SetActive(false);
    }
}
