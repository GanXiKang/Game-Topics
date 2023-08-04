using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InsKickboardControl : MonoBehaviour
{
    public GameObject kickboard;
    public GameObject insPoint;

    public static bool isFollow;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Ocean")
        {
            print("ok");
            Instantiate(kickboard, insPoint.transform.position, insPoint.transform.rotation);
            isFollow = true;
        }
    }
}
