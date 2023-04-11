using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MG1_BoxColliderControl : MonoBehaviour
{
    public static bool playGame = true;
    IEnumerator StartMiniGame()
    {
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene(1);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (playGame == true)
        {
            if (other.tag == "P1" || other.tag == "P2" || other.tag == "P3" || other.tag == "P4")
            {
                if (Dice.P1_totalNum == 5 || Dice.P2_totalNum == 5 || Dice.P3_totalNum == 5 || Dice.P4_totalNum == 5)
                {
                    StartCoroutine(StartMiniGame());
                }
            }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        playGame = true;
    }
}

