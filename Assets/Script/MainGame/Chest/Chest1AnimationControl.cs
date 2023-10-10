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
                        SystemTestTextControl.isTimer = true;
                        CoinControl.P1CoinTotal += randomCoin;
                        AnimatorControl.isP1Win = true;
                        break;
                    case 6:
                    case 7:
                    case 8:
                        randomCoin = Random.Range(20, 30);
                        systemTest.text = "獲得" + randomCoin.ToString() + "個貓貓幣！";
                        SystemTestTextControl.isTimer = true;
                        CoinControl.P1CoinTotal += randomCoin;
                        AnimatorControl.isP1Win = true;
                        break;
                    case 9:
                        systemTest.text = "獲得一個黃金竊手道具！";
                        SystemTestTextControl.isTimer = true;
                        PropsControl.P1Props[6] += 1;
                        AnimatorControl.isP1Jump = true;
                        break;
                    case 10:
                        systemTest.text = "空！";
                        SystemTestTextControl.isTimer = true;
                        AnimatorControl.isP1Lose = true;
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
                        SystemTestTextControl.isTimer = true;
                        CoinControl.P2CoinTotal += randomCoin;
                        AnimatorControl.isP2Win = true;
                        break;
                    case 6:
                    case 7:
                    case 8:
                        randomCoin = Random.Range(20, 30);
                        systemTest.text = "獲得" + randomCoin.ToString() + "個貓貓幣！";
                        SystemTestTextControl.isTimer = true;
                        CoinControl.P2CoinTotal += randomCoin;
                        AnimatorControl.isP2Win = true;
                        break;
                    case 9:
                        systemTest.text = "獲得一個黃金竊手道具！";
                        SystemTestTextControl.isTimer = true;
                        PropsControl.P2Props[6] += 1;
                        AnimatorControl.isP2Jump = true;
                        break;
                    case 10:
                        systemTest.text = "空！";
                        SystemTestTextControl.isTimer = true;
                        AnimatorControl.isP2Lose = true;
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
                        SystemTestTextControl.isTimer = true;
                        CoinControl.P3CoinTotal += randomCoin;
                        AnimatorControl.isP3Win = true;
                        break;
                    case 6:
                    case 7:
                    case 8:
                        randomCoin = Random.Range(20, 30);
                        systemTest.text = "獲得" + randomCoin.ToString() + "個貓貓幣！";
                        SystemTestTextControl.isTimer = true;
                        CoinControl.P3CoinTotal += randomCoin;
                        AnimatorControl.isP3Win = true;
                        break;
                    case 9:
                        systemTest.text = "獲得一個黃金竊手道具！";
                        SystemTestTextControl.isTimer = true;
                        PropsControl.P3Props[6] += 1;
                        AnimatorControl.isP3Jump = true;
                        break;
                    case 10:
                        systemTest.text = "空！";
                        SystemTestTextControl.isTimer = true;
                        AnimatorControl.isP3Lose = true;
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
                        SystemTestTextControl.isTimer = true;
                        CoinControl.P4CoinTotal += randomCoin;
                        AnimatorControl.isP4Win = true;
                        break;
                    case 6:
                    case 7:
                    case 8:
                        randomCoin = Random.Range(20, 30);
                        systemTest.text = "獲得" + randomCoin.ToString() + "個貓貓幣！";
                        SystemTestTextControl.isTimer = true;
                        CoinControl.P4CoinTotal += randomCoin;
                        AnimatorControl.isP4Win = true;
                        break;
                    case 9:
                        systemTest.text = "獲得一個黃金竊手道具！";
                        SystemTestTextControl.isTimer = true;
                        PropsControl.P4Props[6] += 1;
                        AnimatorControl.isP4Jump = true;
                        break;
                    case 10:
                        systemTest.text = "空！";
                        SystemTestTextControl.isTimer = true;
                        AnimatorControl.isP4Lose = true;
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
        yield return new WaitForSeconds(2f);
        FalseByAnimator();
        yield return new WaitForSeconds(1f);
        Destroy(this.gameObject);
    }

    void FalseByAnimator()
    {
        AnimatorControl.isP1Win = false;
        AnimatorControl.isP2Win = false;
        AnimatorControl.isP3Win = false;
        AnimatorControl.isP4Win = false;
        AnimatorControl.isP1Lose = false;
        AnimatorControl.isP2Lose = false;
        AnimatorControl.isP3Lose = false;
        AnimatorControl.isP4Lose = false;
        AnimatorControl.isP1Jump = false;
        AnimatorControl.isP2Jump = false;
        AnimatorControl.isP3Jump = false;
        AnimatorControl.isP4Jump = false;
    }
}
