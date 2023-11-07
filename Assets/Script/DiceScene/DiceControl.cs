using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DiceControl : MonoBehaviour
{
    Rigidbody rb;

    public static int P1_totalNum = 0, P2_totalNum = 0, P3_totalNum = 0, P4_totalNum = 0;

    public int MinNum, MaxNum;
    public float rotationForce;
    public GameObject diceUI, backUI, renewUI, renewWindowsUI , doubleUI, customUI, triplePowerUI, LuckyPowerUI;
    public AudioSource BGM;
    public AudioClip dice;

    int randomNum;
    bool isRoll, result;

    void Start()
    {
        rb = GetComponent<Rigidbody>();

        isRoll = true;

        if (BagUIControl.isRenewDice)
        {
            renewUI.SetActive(true);
            backUI.SetActive(false);
        }
        if (BagUIControl.isDoubleDice)
        {
            doubleUI.SetActive(true);
            backUI.SetActive(false);
        }
        if (BagUIControl.isCustomDice)
        {
            customUI.SetActive(true);
            diceUI.SetActive(false);
            backUI.SetActive(false);
        }
        if (BagUIControl.putBomb || AnimalsPowerControl.dogUsePower)
        {
            backUI.SetActive(false);
        }
        if (AnimalsPowerControl.horseTriplePower)
        {
            triplePowerUI.SetActive(true);
            backUI.SetActive(false);
        }
        if (AnimalsPowerControl.sheepLuckyPower)
        {
            LuckyPowerUI.SetActive(true);
            backUI.SetActive(false);
            MinNum = 4;
        }
    }
    void FixedUpdate()
    {
        if (isRoll)
        {
            rb.AddTorque(Random.insideUnitSphere * rotationForce);
            result = true;
        }
        else
        {
            if (result)
            {
                DiceRandomDice();
                result = false;
            }
        }
    }

    void DiceRandomDice()
    {
        rb.angularVelocity = Vector3.zero;
        if (!BagUIControl.isCustomDice)
        {
            randomNum = Random.Range(MinNum, MaxNum);
        }
        else 
        {
            BagUIControl.isCustomDice = false;
        }
        switch (randomNum)
        {
            case 1:
                transform.rotation = Quaternion.Euler(0f, 270f, 0f);
                break;
            case 2:
                transform.rotation = Quaternion.Euler(0f, 180f, 0f);
                break;
            case 3:
                transform.rotation = Quaternion.Euler(90f, 0f, 0f);
                break;
            case 4:
                transform.rotation = Quaternion.Euler(270f, 0f, 0f);
                break;
            case 5:
                transform.rotation = Quaternion.Euler(0f, 0f, 0f);
                break;
            case 6:
                transform.rotation = Quaternion.Euler(0f, 90f, 0f);
                break;

            default :
                transform.rotation = Quaternion.Euler(0f, 100f, 0f);
                break;
        }
        BGM.PlayOneShot(dice);
    }
    void Calculate()
    {
        switch (ChangeCameraControl.changeCameraNum)
        {
            case 1:
                if (BagUIControl.isDoubleDice || AnimalsPowerControl.horseTriplePower)
                {
                    if (BagUIControl.isDoubleDice)
                    {
                        randomNum *= 2;
                        BagUIControl.isDoubleDice = false;
                    }
                    if (AnimalsPowerControl.horseTriplePower)
                    {
                        randomNum *= 3;
                        AnimalsPowerControl.horseTriplePower = false;
                    }
                    P1_totalNum += randomNum;
                }
                else 
                {
                    P1_totalNum += randomNum;
                }
                AnimatorControl.isP1Move = true;
                break;

            case 2:
                if (BagUIControl.isDoubleDice || AnimalsPowerControl.horseTriplePower)
                {
                    if (BagUIControl.isDoubleDice)
                    {
                        randomNum *= 2;
                        BagUIControl.isDoubleDice = false;
                    }
                    if (AnimalsPowerControl.horseTriplePower)
                    {
                        randomNum *= 3;
                        AnimalsPowerControl.horseTriplePower = false;
                    }
                    P2_totalNum += randomNum;
                }
                else
                {
                    P2_totalNum += randomNum;
                }
                AnimatorControl.isP2Move = true;
                break;

            case 3:
                if (BagUIControl.isDoubleDice || AnimalsPowerControl.horseTriplePower)
                {
                    if (BagUIControl.isDoubleDice)
                    {
                        randomNum *= 2;
                        BagUIControl.isDoubleDice = false;
                    }
                    if (AnimalsPowerControl.horseTriplePower)
                    {
                        randomNum *= 3;
                        AnimalsPowerControl.horseTriplePower = false;
                    }
                    P3_totalNum += randomNum;
                }
                else
                {
                    P3_totalNum += randomNum;
                }
                AnimatorControl.isP3Move = true;
                break;

            case 4:
                if (BagUIControl.isDoubleDice || AnimalsPowerControl.horseTriplePower)
                {
                    if (BagUIControl.isDoubleDice)
                    {
                        randomNum *= 2;
                        BagUIControl.isDoubleDice = false;
                    }
                    if (AnimalsPowerControl.horseTriplePower)
                    {
                        randomNum *= 3;
                        AnimalsPowerControl.horseTriplePower = false;
                    }
                    P4_totalNum += randomNum;
                }
                else
                {
                    P4_totalNum += randomNum;
                }
                AnimatorControl.isP4Move = true;
                break;
        }
    }

    IEnumerator GoMainGame()
    {
        yield return new WaitForSeconds(2f);
        Calculate();
        SceneManager.LoadScene(7);
        if (!PlayerMoveControl.isMove)
        {
            PlayerMoveControl.isMove = true;
        }
        if (AnimalsPowerControl.dragonUsePower)
        {
            switch (ChangeCameraControl.changeCameraNum)
            {
                case 1:
                    if (Menu_ChoosePlayer.whyP1 == 5)
                    {
                        AnimatorControl.isDragonFlyWalk = true;
                    }
                    break;

                case 2:
                    if (Menu_ChoosePlayer.whyP2 == 5)
                    {
                        AnimatorControl.isDragonFlyWalk = true;
                    }
                    break;

                case 3:
                    if (Menu_ChoosePlayer.whyP3 == 5)
                    {
                        AnimatorControl.isDragonFlyWalk = true;
                    }
                    break;

                case 4:
                    if (Menu_ChoosePlayer.whyP4 == 5)
                    {
                        AnimatorControl.isDragonFlyWalk = true;
                    }
                    break;
            }
        }
        if (AnimalsPowerControl.sheepLuckyPower)
        {
            AnimalsPowerControl.sheepLuckyPower = false;
        }
        if (BagUIControl.putBomb)
        {
            BagUIControl.putBomb = false;
        }
        if (AnimalsPowerControl.monkeyUsePower)
        {
            AnimalsPowerControl.monkeyUsePower = false;
        }
        DiceUIControl.isDiceScene = false;
    }
    IEnumerator BackMainGame()
    {
        diceUI.SetActive(false);
        backUI.SetActive(false);
        yield return new WaitForSeconds(0.5f);
        DiceUIControl.isDiceUI = true;
        DiceUIControl.isDiceScene = false;
        SceneManager.LoadScene(7);
    }

    public void Button_Back()
    {
        StartCoroutine(BackMainGame());
    }
    public void Button_Dice()
    {
        if (isRoll)
        {
            isRoll = false;
            AnimalsAnimatorControl.isJump = true;
            if (!BagUIControl.isRenewDice)
            {
                StartCoroutine(GoMainGame());
            }
            else 
            {
                renewWindowsUI.SetActive(true);
            }
        }
        diceUI.SetActive(false);
        backUI.SetActive(false);
    }
    public void Button_Custom(int Num)
    {
        customUI.SetActive(false);
        randomNum = Num;
        if (isRoll)
        {
            isRoll = false;
            AnimalsAnimatorControl.isJump = true;
            StartCoroutine(GoMainGame());
        }
    }
    public void Button_Renew()
    {
        isRoll = true;
        BagUIControl.isRenewDice = false;
        diceUI.SetActive(true);
        backUI.SetActive(false);
        renewUI.SetActive(false);
    }
    public void Button_Cancel()
    {
        BagUIControl.isRenewDice = false;
        switch (ChangeCameraControl.changeCameraNum)
        {
            case 1:
                PropsControl.P1Props[0] += 1;
                break;

            case 2:
                PropsControl.P2Props[0] += 1;
                break;

            case 3:
                PropsControl.P3Props[0] += 1;
                break;

            case 4:
                PropsControl.P4Props[0] += 1;
                break;
        }
        renewUI.SetActive(false);
        StartCoroutine(GoMainGame());
    }
}
