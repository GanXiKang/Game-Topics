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
    void PlayerPlayGameControl()
    {
        if (MiniGameColliderControl.p == 1)
        {
            MiniGameColliderControl.P1_playGame = false;
        }
        if (MiniGameColliderControl.p == 2)
        {
            MiniGameColliderControl.P2_playGame = false;
        }
        if (MiniGameColliderControl.p == 3)
        {
            MiniGameColliderControl.P3_playGame = false;
        }
        if (MiniGameColliderControl.p == 4)
        {
            MiniGameColliderControl.P4_playGame = false;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            gameWinUI.SetActive(true);
            BGM.PlayOneShot(gameWin);
            back = true;
        }
    }
    IEnumerator BackMainGame()
    {
        PlayerPlayGameControl();
        yield return new WaitForSeconds(5f);
        MG6_PlayerMoveControl.j = 1;
        MG6_UIControl.isStart = false;
        MG6_BalanceBarControl.gameover = false;
        back = false;
        SceneManager.LoadScene(7);
        PointJudgeControl.changeScene = true;
    }
}
