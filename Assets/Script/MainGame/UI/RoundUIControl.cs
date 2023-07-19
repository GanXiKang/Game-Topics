using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RoundUIControl : MonoBehaviour
{
    public Text whoRound;
    public Text CoinTotal;

    GameObject P1Camera;
    GameObject P2Camera;
    GameObject P3Camera;
    GameObject P4Camera;

    bool isFind = true;

    void Update()
    {
        if (!UI_LoadingControl.isLoading && isFind)
        {
            FindCamera();
        }
        if (P1Camera.GetComponent<Camera>().enabled)
        {
            print("Yes");
        }
    }
    void FindCamera()
    {
        P1Camera = GameObject.FindGameObjectWithTag("P1Camera");
        P2Camera = GameObject.FindGameObjectWithTag("P2Camera");
        P3Camera = GameObject.FindGameObjectWithTag("P3Camera");
        P4Camera = GameObject.FindGameObjectWithTag("P4Camera");
        isFind = false;
    }
}
