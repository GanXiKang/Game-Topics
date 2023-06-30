using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu_AnimalsTagControl : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "P1InsPoint")
        {
            gameObject.tag = "P1";
        }
        if (other.tag == "P2InsPoint")
        {
            gameObject.tag = "P2";
        }
        if (other.tag == "P3InsPoint")
        {
            gameObject.tag = "P3";
        }
        if (other.tag == "P4InsPoint")
        {
            gameObject.tag = "P4";
        }
    }
}
