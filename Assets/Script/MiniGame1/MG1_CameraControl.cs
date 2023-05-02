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
            StartCoroutine(ChangeCamera());
        }
    }
    IEnumerator ChangeCamera()
    {
        MG1_GameControl.cameraC = false;
        mainCamera.SetActive(false);
        camera1.SetActive(true);
        UI_Button.SetActive(false);

        yield return new WaitForSeconds(0.5f);
        if (MG1_GameControl.W)
        {
            UI_Win.SetActive(true);
            MG1_GameControl.W = false;
        }
        else if (MG1_GameControl.L)
        {
            UI_Lose.SetActive(true);
            MG1_GameControl.L = false;
        }
        else if (MG1_GameControl.D)
        {
            UI_Draw.SetActive(true);
            MG1_GameControl.D = false;
        }

        yield return new WaitForSeconds(0.5f);
        if (MG1_GameControl.cameraEnd)
        {
            camera2.SetActive(true);
            camera1.SetActive(false);

            UI_Win.SetActive(false);
            UI_Lose.SetActive(false);
            UI_Draw.SetActive(false);
            yield return new WaitForSeconds(3f);
        }

        yield return new WaitForSeconds(1f);
        mainCamera.SetActive(true);
        camera1.SetActive(false);
        camera2.SetActive(false);

        UI_Button.SetActive(true);
        UI_Win.SetActive(false);
        UI_Lose.SetActive(false);
        UI_Draw.SetActive(false);
    }
}
