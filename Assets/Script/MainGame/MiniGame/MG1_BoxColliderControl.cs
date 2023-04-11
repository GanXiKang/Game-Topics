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
        if (other.tag == "Player" && playGame == true)
        {
            if (Dice.P1_totalNum == 5 || Dice.P2_totalNum == 5 || Dice.P3_totalNum == 5 || Dice.P4_totalNum == 5)
            {
                StartCoroutine(StartMiniGame());
            }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        playGame = true;
    }
}

