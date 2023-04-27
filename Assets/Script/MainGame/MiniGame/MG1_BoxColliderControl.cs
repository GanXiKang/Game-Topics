using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MG1_BoxColliderControl : MonoBehaviour
{
    public static bool P1_playGame = true, P2_playGame = true, P3_playGame = true, P4_playGame = true;
    public static float p;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "P1" && P1_playGame == true)
        {
            p = 1;
            StartCoroutine(StartMiniGame());
        }
        if (other.tag == "P2" && P2_playGame == true)
        {
            p = 2;
            StartCoroutine(StartMiniGame());
        }
        if (other.tag == "P3" && P3_playGame == true)
        {
            p = 3;
            StartCoroutine(StartMiniGame());
        }
        if (other.tag == "P4" && P4_playGame == true)
        {
            p = 4;
            StartCoroutine(StartMiniGame());
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "P1")
        {
            P1_playGame = true;
        }
        if (other.tag == "P2")
        {
            P2_playGame = true;
        }
        if (other.tag == "P3")
        {
            P3_playGame = true;
        }
        if (other.tag == "P4")
        {
            P4_playGame = true;
        }
    }
    IEnumerator StartMiniGame()
    {
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene(2);
    }
}

