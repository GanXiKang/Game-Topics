using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MG6_EndControl : MonoBehaviour
{
    bool back;
    void Update()
    {
        if (back == true)
        {
            StartCoroutine(BackMainGame());
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "End")
        {
            print("Win!");
            MG6_PlayerMoveControl.isMove = false;
            back = true;
        }
    }
    IEnumerator BackMainGame()
    {
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene(0);
    }
}
