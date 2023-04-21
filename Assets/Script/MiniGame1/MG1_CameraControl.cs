using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MG1_CameraControl : MonoBehaviour
{
    public GameObject mainCamera;
    public GameObject camera1;

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
        yield return new WaitForSeconds(2f);
        mainCamera.SetActive(true);
        camera1.SetActive(false);
    }
}
