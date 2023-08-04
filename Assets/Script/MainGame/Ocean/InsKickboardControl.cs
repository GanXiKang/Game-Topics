using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InsKickboardControl : MonoBehaviour
{
    public GameObject kickboard;

    public static bool isFollow;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Ocean")
        {
            Instantiate(kickboard, transform.position, transform.rotation);
            isFollow = true;
        }
    }
}
