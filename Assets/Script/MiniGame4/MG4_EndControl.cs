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
    {                                           //�Д��l���
        if (other.tag == "Player")              
        {
            print("1");
            win = false;                        //AI�ȵ��K�c
            arriveEnd++;
        }
        if (other.tag == "AI")
        {
            print("2");
            win = true;                         //Player�ȵ��K�c
            arriveEnd++;
        }
    }
}
