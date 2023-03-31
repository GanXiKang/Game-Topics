using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxControl : MonoBehaviour
{
    Animation ani;
    float a;

    void Start()
    {
        ani = GetComponent<Animation>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player" && Dice.totalNum == 2)
        {
            ani.Play("Open");
            a = Random.Range(1, 11);
            switch (a) 
            {
                case 1:
                case 2:
                case 3:
                case 4:
                    print("獲得10個貓貓幣！");
                    break;
                case 5:
                case 6:
                    print("獲得20個貓貓幣！");
                    break;
                case 7:
                case 8:
                    print("獲得30個貓貓幣！");
                    break;
                case 9:
                    print("獲得一個道具！");
                    break;
                case 10:
                    print("空！");
                    break;
            }
            Destroy(this.gameObject, 2f);
        }
    }
}
