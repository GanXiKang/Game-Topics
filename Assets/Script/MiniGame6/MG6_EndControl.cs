using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MG6_EndControl : MonoBehaviour
{
    public GameObject gameWinUI;
    public AudioSource BGM;
    public AudioClip gameWin;

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
            gameWinUI.SetActive(true);
            BGM.PlayOneShot(gameWin);
            back = true;
        }
    }
    IEnumerator BackMainGame()
    {
        yield return new WaitForSeconds(5f);
        SceneManager.LoadScene(7);
        back = false;
        MG6_UIControl.isStart = false;
        MG6_BalanceBarControl.gameover = false;
        MG6_PlayerMoveControl.j = 1;
    }
}
