using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MG1_CameraControl : MonoBehaviour
{
    public GameObject mainCamera;
    public GameObject camera1;
    public GameObject UI_Scissors;
    public GameObject UI_Stone;
    public GameObject UI_Cloth;
    public GameObject UI_Win;
    public GameObject UI_Lose;
    public GameObject UI_Draw;

    void Update()
    {
        if (MG1_GameControl.cameraC == true)
        {
            StartCoroutine(ChangeCamera());
        }
    }
    IEnumerator ChangeCamera()
    {
        MG1_GameControl.cameraC = false;
        mainCamera.SetActive(false);
        camera1.SetActive(true);
        UI_Scissors.SetActive(false);
        UI_Stone.SetActive(false);
        UI_Cloth.SetActive(false);
        yield return new WaitForSeconds(1f);
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
        yield return new WaitForSeconds(2f);
        mainCamera.SetActive(true);
        camera1.SetActive(false);

        UI_Scissors.SetActive(true);
        UI_Stone.SetActive(true);
        UI_Cloth.SetActive(true);

        UI_Win.SetActive(false);
        UI_Lose.SetActive(false);
        UI_Draw.SetActive(false);
    }
}
