using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MG1_CameraControl : MonoBehaviour
{
    public GameObject mainCamera, camera1, camera2;
    public GameObject UI_Button, UI_Win, UI_Lose, UI_Draw;

    void Update()
    {
        if (MG1_GameControl.cameraC)
        {
            StartCoroutine(ChangeCamera1());
        }
    }
    IEnumerator ChangeCamera1()
    {
        MG1_GameControl.cameraC = false;
        mainCamera.SetActive(false);
        camera1.SetActive(true);
        UI_Button.SetActive(false);

        yield return new WaitForSeconds(0.5f);
        if (MG1_GameControl.W == true)
        {
            UI_Win.SetActive(true);
            MG1_GameControl.W = false;
        }
        if (MG1_GameControl.L == true)
        {
            UI_Lose.SetActive(true);
            MG1_GameControl.L = false;
        }
        if (MG1_GameControl.D == true)
        {
            UI_Draw.SetActive(true);
            MG1_GameControl.D = false;
        }
        yield return new WaitForSeconds(1.5f);
        mainCamera.SetActive(true);
        camera1.SetActive(false);

        UI_Button.SetActive(true);

        UI_Win.SetActive(false);
        UI_Lose.SetActive(false);
        UI_Draw.SetActive(false);
    }
}
