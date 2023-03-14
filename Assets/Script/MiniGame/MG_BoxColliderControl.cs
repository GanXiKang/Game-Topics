using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MG_BoxColliderControl : MonoBehaviour
{
    IEnumerator StartMiniGame()
    {
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene(1);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player" && Dice.totalNum == 5)
        {
            StartCoroutine(StartMiniGame());
        }
    }
}
