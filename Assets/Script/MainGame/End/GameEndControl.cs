using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameEndControl : MonoBehaviour
{
    public Text systemTest;

    private void OnTriggerEnter(Collider other)
    {
        StartCoroutine(BackMainMenu());
    }
    IEnumerator BackMainMenu()
    {
        systemTest.text = "ÓÎ‘ò½YÊø£¡";
        systemTest.color = Color.blue;
        SystemTestTextControl.isTimer = true;
        yield return new WaitForSeconds(5f);
        SceneManager.LoadScene(0);
        Menu_ChoosePlayer.whoPlay = 0;
    }
}
