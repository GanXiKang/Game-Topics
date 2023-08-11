using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InsKickboardControl : MonoBehaviour
{
    public GameObject kickboard;

    bool isFollow;

    public static bool insKickboard, destoryKickboard;
    void Start()
    {
        kickboard.SetActive(false);
    }
    void Update()
    {
        if (isFollow)
        {
            kickboard.SetActive(true);
        }
        else
        {
            kickboard.SetActive(false);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Ocean")
        {
            isFollow = true;
            insKickboard = true;
        }
    }
    private void OnTriggerExit(Collider other)
    { 
        if (other.tag == "Ocean")
        { 
            isFollow = false;
            destoryKickboard = true;
        }
    }
}
