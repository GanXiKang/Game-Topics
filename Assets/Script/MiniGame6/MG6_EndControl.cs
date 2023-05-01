using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MG6_EndControl : MonoBehaviour
{
    public static bool back = false;
    void Update()
    {
        if (back || MG6_BalanceBarControl.gameover)
        {
            StartCoroutine(BackMainGame());
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "End")
        {
            print("Win!");
            back = true;
        }
    }
    IEnumerator BackMainGame()
    {
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene(7);
        back = false;
        MG6_BalanceBarControl.gameover = false;
        MG6_PlayerMoveControl.j = 1;
    }
}
