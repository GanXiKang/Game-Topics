using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DiceControl : MonoBehaviour
{
    Rigidbody rb;

    public static int P1_totalNum = 0, P2_totalNum = 0, P3_totalNum = 0, P4_totalNum = 0, round = 0;

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
            print("Yes");
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
        randomNum = Random.Range(1, 7);
        print(randomNum);
        Calculate();
        
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
        }
        round++;
    }
    void Calculate()
    {
        ChangeCameraControl.changeCameraNum = Dice.who;
        switch (Dice.who)
        {
            case 1:
                P1_totalNum += randomNum;
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
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(7);
        Dice.isDiceScene = false;
        yield return new WaitForSeconds(1f);
        Calculate();
    }
}
