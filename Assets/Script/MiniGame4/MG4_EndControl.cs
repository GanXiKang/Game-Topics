using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MG4_EndControl : MonoBehaviour
{
    float arriveEnd = 0;
    bool win;
    void Update()
    {
        if (arriveEnd == 2)
        {
            if (win == true)
            {
                print("Win");
            }
            else 
            {
                print("Lose");
            }
        }
    }
    private void OnTriggerEnter(Collider other)
    {                                           //判斷誰最后到
        if (other.tag == "Player")              
        {
            print("1");
            win = false;                        //AI先到終點
            arriveEnd++;
        }
        if (other.tag == "AI")
        {
            print("2");
            win = true;                         //Player先到終點
            arriveEnd++;
        }
    }
}
