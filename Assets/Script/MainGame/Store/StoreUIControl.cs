using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StoreUIControl : MonoBehaviour
{
    public GameObject[] StoreUI = new GameObject[4];
    public Text[] howMuchCoin = new Text[7];

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
    public void Button_Porps(int why)
    {
        StoreUI[2].SetActive(false);
        StoreUI[3].SetActive(true);
    }
    public void Button_Cancel()
    {
        StoreUI[2].SetActive(true);
        StoreUI[3].SetActive(false);
    }
    public void Button_Buy()
    {
        StoreUI[2].SetActive(true);
        StoreUI[3].SetActive(false);
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
