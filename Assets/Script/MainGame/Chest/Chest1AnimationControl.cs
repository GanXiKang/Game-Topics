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

    int a, randomCoin;
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
        a = Random.Range(1, 10);
        switch (ChangeCameraControl.changeCameraNum)
        {
            case 1:
                switch (a)
                {
                    case 1:
                    case 2:
                    case 3:
                    case 4:
                    case 5:
                        randomCoin = Random.Range(10, 20);
                        systemTest.text = "獲得" + randomCoin.ToString() + "個貓貓幣！";
                        systemTest.color = Color.yellow;
                        SystemTestTextControl.isTimer = true;
                        CoinControl.P1CoinTotal += randomCoin;
                        break;
                    case 6:
                    case 7:
                    case 8:
                        randomCoin = Random.Range(20, 30);
                        systemTest.text = "獲得" + randomCoin.ToString() + "個貓貓幣！";
                        systemTest.color = Color.yellow;
                        SystemTestTextControl.isTimer = true;
                        CoinControl.P1CoinTotal += randomCoin;
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
                    case 5:
                        randomCoin = Random.Range(10, 20);
                        systemTest.text = "獲得" + randomCoin.ToString() + "個貓貓幣！";
                        systemTest.color = Color.yellow;
                        SystemTestTextControl.isTimer = true;
                        CoinControl.P2CoinTotal += randomCoin;
                        break;
                    case 6:
                    case 7:
                    case 8:
                        randomCoin = Random.Range(20, 30);
                        systemTest.text = "獲得" + randomCoin.ToString() + "個貓貓幣！";
                        systemTest.color = Color.yellow;
                        SystemTestTextControl.isTimer = true;
                        CoinControl.P2CoinTotal += randomCoin;
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
                    case 5:
                        randomCoin = Random.Range(10, 20);
                        systemTest.text = "獲得" + randomCoin.ToString() + "個貓貓幣！";
                        systemTest.color = Color.yellow;
                        SystemTestTextControl.isTimer = true;
                        CoinControl.P3CoinTotal += randomCoin;
                        break;
                    case 6:
                    case 7:
                    case 8:
                        randomCoin = Random.Range(20, 30);
                        systemTest.text = "獲得" + randomCoin.ToString() + "個貓貓幣！";
                        systemTest.color = Color.yellow;
                        SystemTestTextControl.isTimer = true;
                        CoinControl.P3CoinTotal += randomCoin;
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
                    case 5:
                        randomCoin = Random.Range(10, 20);
                        systemTest.text = "獲得" + randomCoin.ToString() + "個貓貓幣！";
                        systemTest.color = Color.yellow;
                        SystemTestTextControl.isTimer = true;
                        CoinControl.P4CoinTotal += randomCoin;
                        break;
                    case 6:
                    case 7:
                    case 8:
                        randomCoin = Random.Range(20, 30);
                        systemTest.text = "獲得" + randomCoin.ToString() + "個貓貓幣！";
                        systemTest.color = Color.yellow;
                        SystemTestTextControl.isTimer = true;
                        CoinControl.P4CoinTotal += randomCoin;
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
