using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Chest1AnimationControl : MonoBehaviour
{
    Animation ani;

    public GameObject effects;
    public Transform pointEff;
    public Text systemTest;
    public AudioSource BGM;
    public AudioClip open;
    public int checkIsOpenNum;

    int a;
    void Start()
    {
        ani = GetComponent<Animation>();
    }
    void Update()
    {
        if (checkIsOpenNum == ChestColliderControl.isOpen)
        {
            StartCoroutine(ChestActive());
        }
    }
    void Award()
    {
        a = Random.Range(1, 11);
        switch (ChangeCameraControl.changeCameraNum)
        {
            case 1:
                switch (a)
                {
                    case 1:
                    case 2:
                    case 3:
                    case 4:
                        systemTest.text = "獲得10個貓貓幣！";
                        systemTest.color = Color.yellow;
                        SystemTestTextControl.isTimer = true;
                        CoinControl.P1CoinTotal += 10;
                        break;
                    case 5:
                    case 6:
                        systemTest.text = "獲得20個貓貓幣！";
                        systemTest.color = Color.yellow;
                        SystemTestTextControl.isTimer = true;
                        CoinControl.P1CoinTotal += 20;
                        break;
                    case 7:
                    case 8:
                        systemTest.text = "獲得30個貓貓幣！";
                        systemTest.color = Color.yellow;
                        SystemTestTextControl.isTimer = true;
                        CoinControl.P1CoinTotal += 30;
                        break;
                    case 9:
                        systemTest.text = "獲得一個黃金竊手道具！";
                        systemTest.color = Color.yellow;
                        SystemTestTextControl.isTimer = true;
                        PropsControl.P1Props[6] += 1;
                        break;
                    case 10:
                        systemTest.text = "空！";
                        systemTest.color = Color.black;
                        SystemTestTextControl.isTimer = true;
                        break;
                }
                break;

            case 2:
                switch (a)
                {
                    case 1:
                    case 2:
                    case 3:
                    case 4:
                        systemTest.text = "獲得10個貓貓幣！";
                        systemTest.color = Color.yellow;
                        SystemTestTextControl.isTimer = true;
                        CoinControl.P2CoinTotal += 10;
                        break;
                    case 5:
                    case 6:
                        systemTest.text = "獲得20個貓貓幣！";
                        systemTest.color = Color.yellow;
                        SystemTestTextControl.isTimer = true;
                        CoinControl.P2CoinTotal += 20;
                        break;
                    case 7:
                    case 8:
                        systemTest.text = "獲得30個貓貓幣！";
                        systemTest.color = Color.yellow;
                        SystemTestTextControl.isTimer = true;
                        CoinControl.P2CoinTotal += 30;
                        break;
                    case 9:
                        systemTest.text = "獲得一個黃金竊手道具！";
                        systemTest.color = Color.yellow;
                        SystemTestTextControl.isTimer = true;
                        PropsControl.P2Props[6] += 1;
                        break;
                    case 10:
                        systemTest.text = "空！";
                        systemTest.color = Color.black;
                        SystemTestTextControl.isTimer = true;
                        break;
                }
                break;

            case 3:
                switch (a)
                {
                    case 1:
                    case 2:
                    case 3:
                    case 4:
                        systemTest.text = "獲得10個貓貓幣！";
                        systemTest.color = Color.yellow;
                        SystemTestTextControl.isTimer = true;
                        CoinControl.P3CoinTotal += 10;
                        break;
                    case 5:
                    case 6:
                        systemTest.text = "獲得20個貓貓幣！";
                        systemTest.color = Color.yellow;
                        SystemTestTextControl.isTimer = true;
                        CoinControl.P3CoinTotal += 20;
                        break;
                    case 7:
                    case 8:
                        systemTest.text = "獲得30個貓貓幣！";
                        systemTest.color = Color.yellow;
                        SystemTestTextControl.isTimer = true;
                        CoinControl.P3CoinTotal += 30;
                        break;
                    case 9:
                        systemTest.text = "獲得一個黃金竊手道具！";
                        systemTest.color = Color.yellow;
                        SystemTestTextControl.isTimer = true;
                        PropsControl.P3Props[6] += 1;
                        break;
                    case 10:
                        systemTest.text = "空！";
                        systemTest.color = Color.black;
                        SystemTestTextControl.isTimer = true;
                        break;
                }
                break;

            case 4:
                switch (a)
                {
                    case 1:
                    case 2:
                    case 3:
                    case 4:
                        systemTest.text = "獲得10個貓貓幣！";
                        systemTest.color = Color.yellow;
                        SystemTestTextControl.isTimer = true;
                        CoinControl.P4CoinTotal += 10;
                        break;
                    case 5:
                    case 6:
                        systemTest.text = "獲得20個貓貓幣！";
                        systemTest.color = Color.yellow;
                        SystemTestTextControl.isTimer = true;
                        CoinControl.P4CoinTotal += 20;
                        break;
                    case 7:
                    case 8:
                        systemTest.text = "獲得30個貓貓幣！";
                        systemTest.color = Color.yellow;
                        SystemTestTextControl.isTimer = true;
                        CoinControl.P4CoinTotal += 30;
                        break;
                    case 9:
                        systemTest.text = "獲得一個黃金竊手道具！";
                        systemTest.color = Color.yellow;
                        SystemTestTextControl.isTimer = true;
                        PropsControl.P4Props[6] += 1;
                        break;
                    case 10:
                        systemTest.text = "空！";
                        systemTest.color = Color.black;
                        SystemTestTextControl.isTimer = true;
                        break;
                }
                break;
        }
    }
    IEnumerator ChestActive()
    {
        Award();
        ani.Play("Open");
        BGM.PlayOneShot(open);
        Instantiate(effects, pointEff.transform.position, pointEff.transform.rotation);
        ChestColliderControl.isOpen = 0;
        yield return new WaitForSeconds(3f);
        Destroy(this.gameObject);
    }
}
