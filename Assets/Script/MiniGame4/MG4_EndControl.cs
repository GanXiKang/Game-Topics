using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MG4_EndControl : MonoBehaviour
{
    Animator ani;

    float arriveEnd = 0;
    bool win;
    void Start()
    {
        ani = GetComponent<Animator>();
    }
    void Update()
    {
        if (arriveEnd == 2)
        {
            if (win == true)
            {
                print("Win");
                ani.SetBool("Walk", false);
                ani.SetBool("Win", true);
            }
            else 
            {
                print("Lose");
                ani.SetBool("Walk", false);
                ani.SetBool("Lose", true);
            }
            StartCoroutine(BackMainGame());
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
    IEnumerator BackMainGame()
    {
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene(0);
        MG4_UIControl.isStart = false;
        MG4_RoadBlockControl.combo = 0;
    }
}
