using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_LoadingControl : MonoBehaviour
{
    float timer;
    void Update()
    {
        timer += 1 * Time.deltaTime;

        if (timer >= 5)                            //Õý³£ÊÇ5
        {
            Destroy(this.gameObject);
        }
    }
}
