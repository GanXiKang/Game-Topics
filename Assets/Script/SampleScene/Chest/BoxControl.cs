using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxControl : MonoBehaviour
{
    Animation ani;
    int a;
    float isOpen;

    void Start()
    {
        ani = GetComponent<Animation>();
    }
    void Update()
    {
        if (ChestColliderControl.isOpen != 0)
        {
            ani.Play("Open");
            ChestColliderControl.isOpen = 0;
        }
    }
        private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player" && Dice.totalNum == 2)
        {
            isOpen = 1;
            a = Random.Range(1, 11);
            switch (a)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                    print("�@��10��؈؈�ţ�");
                    break;
                case 5:
                case 6:
                    print("�@��20��؈؈�ţ�");
                    break;
                case 7:
                case 8:
                    print("�@��30��؈؈�ţ�");
                    break;
                case 9:
                    print("�@��һ�����ߣ�");
                    break;
                case 10:
                    print("�գ�");
                    break;
            }
            Destroy(this.gameObject, 2f);
        }
        if (other.tag == "Player" && Dice.totalNum == 3)
        {
            isOpen = 1;
            a = Random.Range(1, 11);
            switch (a)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                    print("�@��10��؈؈�ţ�");
                    break;
                case 5:
                case 6:
                    print("�@��20��؈؈�ţ�");
                    break;
                case 7:
                case 8:
                    print("�@��30��؈؈�ţ�");
                    break;
                case 9:
                    print("�@��һ�����ߣ�");
                    break;
                case 10:
                    print("�գ�");
                    break;
            }
            Destroy(this.gameObject, 2f);
        }
    }
}
