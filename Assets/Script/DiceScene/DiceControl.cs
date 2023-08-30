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
    public GameObject normalUI, renewUI, doubleUI, customUI;

    int randomNum;
    bool isRoll, result, isRenew;

    void Start()
    {
        rb = GetComponent<Rigidbody>();

        isRoll = true;

        if (BagUIControl.isDoubleDice)
        {
            doubleUI.SetActive(true);
        }
        if (BagUIControl.isCustomDice)
        {
            customUI.SetActive(true);
            normalUI.SetActive(false);
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
            }
        }
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (isRoll)
            {
                StartCoroutine(GoMainGame());
            }
            else
            {
                isRoll = true;
            }
        }
    }
    void DiceRandomDice()
    {
        result = false;
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
        print(randomNum);
    }
    void Calculate()
    {
        switch (ChangeCameraControl.changeCameraNum)
        {
            case 1:
                if (BagUIControl.isDoubleDice)
                {
                    randomNum *= 2;
                    P1_totalNum += randomNum;
                    BagUIControl.isDoubleDice = false;
                }
                else 
                {
                    P1_totalNum += randomNum;
                }
                AnimatorControl.isP1Move = true;
                break;

            case 2:
                if (BagUIControl.isDoubleDice)
                {
                    randomNum *= 2;
                    P2_totalNum += randomNum;
                    BagUIControl.isDoubleDice = false;
                }
                else
                {
                    P2_totalNum += randomNum;
                }
                AnimatorControl.isP2Move = true;
                break;

            case 3:
                if (BagUIControl.isDoubleDice)
                {
                    randomNum *= 2;
                    P3_totalNum += randomNum;
                    BagUIControl.isDoubleDice = false;
                }
                else
                {
                    P3_totalNum += randomNum;
                }
                AnimatorControl.isP3Move = true;
                break;

            case 4:
                if (BagUIControl.isDoubleDice)
                {
                    randomNum *= 2;
                    P4_totalNum += randomNum;
                    BagUIControl.isDoubleDice = false;
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
        isRoll = false;
        AnimalsAnimatorControl.isJump = true;
        if (BagUIControl.isRenewDice)
        {
            renewUI.SetActive(true);
            normalUI.SetActive(false);
            if (isRenew)
            {
                isRoll = true;
                BagUIControl.isRenewDice = false;
            }
            else
            {
                yield return new WaitForSeconds(2.5f);
                Calculate();
                SceneManager.LoadScene(7);
                PlayerMoveControl.isMove = true;
                DiceUIControl.isDiceScene = false;
            }
        }
        else
        {
            yield return new WaitForSeconds(2.5f);
            Calculate();
            SceneManager.LoadScene(7);
            PlayerMoveControl.isMove = true;
            DiceUIControl.isDiceScene = false;
        }
    }
    
    IEnumerator BackMainGame()
    {
        normalUI.SetActive(false);
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
            StartCoroutine(GoMainGame());
        }
        else
        {
            isRoll = true;
        }
        normalUI.SetActive(false);
    }
    public void Button_Custom(int Num)
    {
        customUI.SetActive(false);
        randomNum = Num;
        if (isRoll)
        {
            StartCoroutine(GoMainGame());
        }
        else
        {
            isRoll = true;
        }
    }
    public void Button_Renew()
    {
        isRenew = true;
        normalUI.SetActive(true);
        renewUI.SetActive(false);
    }
    public void Button_NoRenew()
    {
        isRenew = false;
        renewUI.SetActive(false);
    }
}
