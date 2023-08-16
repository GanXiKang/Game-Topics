using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StoreUIControl : MonoBehaviour
{
    public GameObject[] StoreUI = new GameObject[4];
    public Text[] howMuchCoin = new Text[6];

    public static bool isStore = false, isBuying = false;

    void Update()
    {
        if (isStore)
        {
            StoreUI[1].SetActive(true);
            isStore = false;
        }
    }

    public void Button_Yes()
    {
        isBuying = true;
        StoreUI[1].SetActive(false);
        StoreUI[2].SetActive(true);
    }
    public void Button_NO()
    {
        StartCoroutine(ChangeCamera());
    }
    IEnumerator ChangeCamera()
    {
        StoreUI[1].SetActive(false);
        StoreUI[2].SetActive(false);
        yield return new WaitForSeconds(1f);
        ChangeCameraControl.changeCameraNum++;
        Dice.isDiceUI = true;
    }
}
