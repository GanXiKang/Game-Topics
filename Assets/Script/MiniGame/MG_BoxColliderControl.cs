using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MG_BoxColliderControl : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player" && Dice.totalNum == 5)
        {
            SceneManager.LoadScene(1);
        }
    }
}
