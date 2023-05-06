using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IsPointColliderControl : MonoBehaviour
{
    GameObject Interactive_UI;

    void Start()
    {
        Interactive_UI = GameObject.Find("InteractiveUI");
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Point")
        {
            
        }
    }
    IEnumerator NextPlayer()
    {
        yield return new WaitForSeconds(3f);
        Interactive_UI.SetActive(true);
        CameraControl.changeCamera++;
    }
}

