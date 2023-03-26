using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MG3_StarControl : MonoBehaviour
{
    public GameObject star;
    public Transform insPoint1, insPoint2, insPoint3;

    public static bool insStar;
    float x,win,result;

    void Update()
    {
        if (MG3_ButtonControl.round <= 3)
        {
            if (insStar == true)
            {
                x = Random.Range(1, 4);
                switch (x)
                {
                    case 1:
                        Instantiate(star, insPoint1.transform.position, insPoint1.transform.rotation);
                        break;
                    case 2:
                        Instantiate(star, insPoint2.transform.position, insPoint2.transform.rotation);
                        break;
                    case 3:
                        Instantiate(star, insPoint3.transform.position, insPoint3.transform.rotation);
                        break;
                }
                insStar = false;
            }
            if (MG3_ButtonControl.openBox == true)
            {
                if (MG3_ButtonControl.openWhyBox == x)
                {
                    win++;
                    print("Win");
                }
                else
                {
                    print("Lose");
                    if (x == 1)
                    {
                        MG3_BoxMoveControl.openBox1 = true;
                    }
                    if (x == 2)
                    {
                        MG3_BoxMoveControl.openBox2 = true;
                    }
                    if (x == 3)
                    {
                        MG3_BoxMoveControl.openBox3 = true;
                    }
                }
                result++;
                MG3_ButtonControl.openBox = false;
            }
        }
        if (result == 3)
        {
            if (win >= 2)
            {
                print("�Α������");
            }
            else
            {
                print("�Α�ʧ����");
            }
            StartCoroutine(BackMainGame());
        }
    }
    IEnumerator BackMainGame()
    {
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene(0);
    }
}
