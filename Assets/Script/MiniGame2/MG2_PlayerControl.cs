using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MG2_PlayerControl : MonoBehaviour
{
    public float speed = 20f;
    void Start()
    {
        
    }

    void Update()
    {
        if (MG2_UIControl.gameTime > 0)
        {
            if (Input.GetKey("a"))
            {
                transform.Translate(-speed * Time.deltaTime, 0, 0);
            }
            if (Input.GetKey("d"))
            {
                transform.Translate(speed * Time.deltaTime, 0, 0);
            }
        }
    }
}
