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
        yield return new WaitForSeconds(5f);
        SceneManager.LoadScene(0);
    }
}
