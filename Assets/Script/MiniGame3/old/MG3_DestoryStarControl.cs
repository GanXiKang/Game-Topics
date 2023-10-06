using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MG3_DestoryStarControl : MonoBehaviour
{
    void Update()
    {
        if (MG3_ButtonControl.destoryStarNum >= 2 && MG3_ButtonControl.destoryStar)
        {
            MG3_ButtonControl.destoryStar = false;
            Destroy(this.gameObject);
        }
    }
}
