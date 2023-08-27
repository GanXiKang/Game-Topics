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

    int randomNum;
    bool isRoll, result;

    void Start()
    {
        rb = GetComponent<Rigidbody>();

        isRoll = true;
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
                isRoll = false;
                AnimalsAnimatorControl.isJump = true;
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
        randomNum = Random.Range(MinNum, MaxNum);
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
        Calculate();
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
                P2_totalNum += randomNum;
                AnimatorControl.isP2Move = true;
                break;

            case 3:
                P3_totalNum += randomNum;
                AnimatorControl.isP3Move = true;
                break;

            case 4:
                P4_totalNum += randomNum;
                AnimatorControl.isP4Move = true;
                break;
        }
    }
    IEnumerator GoMainGame()
    {
        yield return new WaitForSeconds(2.5f);
        SceneManager.LoadScene(7);
        PlayerMoveControl.isMove = true;
        DiceUIControl.isDiceScene = false;
    }
}
