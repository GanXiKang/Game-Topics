using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MG2_GameResultControl : MonoBehaviour
{
    void Update()
    {
        if (MG2_UIControl.gameTime <= 0)
        {
            if (MG2_CollectScoreControl.score >= 40)
            {
                print("Win");
            }
            else 
            {
                print("Lose");
            }
            SceneManager.LoadScene(0);
        }
    }
}
