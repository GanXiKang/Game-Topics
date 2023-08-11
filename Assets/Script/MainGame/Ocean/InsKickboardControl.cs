using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InsKickboardControl : MonoBehaviour
{
    public GameObject kickboard;
    //public GameObject insPoint;

    //GameObject kickboardFollow;
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
            //kickboardFollow.transform.position = insPoint.transform.position;
            kickboard.SetActive(true);
        }
        else
        {
            //Destroy(kickboardFollow, 1f);
            kickboard.SetActive(false);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Ocean")
        {
            //kickboardFollow = Instantiate(kickboard, insPoint.transform.position, insPoint.transform.rotation);
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
