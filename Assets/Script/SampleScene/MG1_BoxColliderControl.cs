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
        if (other.tag == "Player" && Dice.totalNum == 5 && playGame == true)
        {
            StartCoroutine(StartMiniGame());
        }
    }
    private void OnTriggerExit(Collider other)
    {
        playGame = true;
    }
}

