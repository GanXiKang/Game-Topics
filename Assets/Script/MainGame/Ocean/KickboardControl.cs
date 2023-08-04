using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KickboardControl : MonoBehaviour
{
    GameObject insKickboardPoint;

    void Start()
    {
        insKickboardPoint = GameObject.Find("InsKickPoint");
    }

    void Update()
    {
        if (InsKickboardControl.isFollow)
        {
            transform.position = insKickboardPoint.transform.position;
        }
        else 
        {
            Destroy(this.gameObject, 2f);
        }
      
    }
}
