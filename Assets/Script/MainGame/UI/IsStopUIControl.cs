using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IsStopUIControl : MonoBehaviour
{
    public Text systemText;

    public static int isStopUI = 0, isBombStopUI = 0, isCowPowerStopUI = 0, isSnakePowerStopUI = 0, isBananaStopUI;
    public static bool isBombStopP1, isBombStopP2, isBombStopP3, isBombStopP4;
    public static bool isPoisonStopP1, isPoisonStopP2, isPoisonStopP3, isPoisonStopP4;
    public static bool isBananaStopP1, isBananaStopP2, isBananaStopP3, isBananaStopP4;

    void Update()
    {
        AnimalsConfusion();

        if (!AnimalsPowerControl.tigerUsePower)
        {
            if (isStopUI != 0)
            {
                switch (ChangeCameraControl.changeCameraNum)
                {
                    case 1:
                        if (EventControl.isStopP1)
                        {
                            StartCoroutine(StopThisRound());
                            EventControl.isStopP1 = false;
                        }
                        break;

                    case 2:
                        if (EventControl.isStopP2)
                        {
                            StartCoroutine(StopThisRound());
                            EventControl.isStopP2 = false;
                        }
                        break;

                    case 3:
                        if (EventControl.isStopP3)
                        {
                            StartCoroutine(StopThisRound());
                            EventControl.isStopP3 = false;
                        }
                        break;

                    case 4:
                        if (EventControl.isStopP4)
                        {
                            StartCoroutine(StopThisRound());
                            EventControl.isStopP4 = false;
                        }
                        break;
                }
            }
            if (isBombStopUI != 0 && !StoreColliderControl.isStoreNotStopUI)
            {
                switch (ChangeCameraControl.changeCameraNum)
                {
                    case 1:
                        if (isBombStopP1)
                        {
                            StartCoroutine(BombStopThisRound());
                            isBombStopP1 = false;
                        }
                        break;

                    case 2:
                        if (isBombStopP2)
                        {
                            StartCoroutine(BombStopThisRound());
                            isBombStopP2 = false;
                        }
                        break;

                    case 3:
                        if (isBombStopP3)
                        {
                            StartCoroutine(BombStopThisRound());
                            isBombStopP3 = false;
                        }
                        break;

                    case 4:
                        if (isBombStopP4)
                        {
                            StartCoroutine(BombStopThisRound());
                            isBombStopP4 = false;
                        }
                        break;
                }
            }
            if (isCowPowerStopUI != 0)
            {
                switch (ChangeCameraControl.changeCameraNum)
                {
                    case 1:
                        if (CowPowerControl.isCowPowerStopP1)
                        {
                            StartCoroutine(CowPowerStopThisRound());
                            CowPowerControl.isCowPowerStopP1 = false;
                        }
                        break;

                    case 2:
                        if (CowPowerControl.isCowPowerStopP2)
                        {
                            StartCoroutine(CowPowerStopThisRound());
                            CowPowerControl.isCowPowerStopP2 = false;
                        }
                        break;

                    case 3:
                        if (CowPowerControl.isCowPowerStopP3)
                        {
                            StartCoroutine(CowPowerStopThisRound());
                            CowPowerControl.isCowPowerStopP3 = false;
                        }
                        break;

                    case 4:
                        if (CowPowerControl.isCowPowerStopP4)
                        {
                            StartCoroutine(CowPowerStopThisRound());
                            CowPowerControl.isCowPowerStopP4 = false;
                        }
                        break;
                }
            }
            if (isSnakePowerStopUI != 0)
            {
                switch (ChangeCameraControl.changeCameraNum)
                {
                    case 1:
                        if (isPoisonStopP1)
                        {
                            StartCoroutine(SnakePowerStopThisRound());
                            isPoisonStopP1 = false;
                        }
                        break;

                    case 2:
                        if (isPoisonStopP2)
                        {
                            StartCoroutine(SnakePowerStopThisRound());
                            isPoisonStopP2 = false;
                        }
                        break;

                    case 3:
                        if (isPoisonStopP3)
                        {
                            StartCoroutine(SnakePowerStopThisRound());
                            isPoisonStopP3 = false;
                        }
                        break;

                    case 4:
                        if (isPoisonStopP4)
                        {
                            StartCoroutine(SnakePowerStopThisRound());
                            isPoisonStopP4 = false;
                        }
                        break;
                }
            }
            if (isBananaStopUI != 0 && !StoreColliderControl.isStoreNotStopUI)
            {
                switch (ChangeCameraControl.changeCameraNum)
                {
                    case 1:
                        if (isBananaStopP1)
                        {
                            StartCoroutine(BananaStopThisRound());
                            isBananaStopP1 = false;
                        }
                        break;

                    case 2:
                        if (isBananaStopP2)
                        {
                            StartCoroutine(BananaStopThisRound());
                            isBananaStopP2 = false;
                        }
                        break;

                    case 3:
                        if (isBananaStopP3)
                        {
                            StartCoroutine(BananaStopThisRound());
                            isBananaStopP3 = false;
                        }
                        break;

                    case 4:
                        if (isBananaStopP4)
                        {
                            StartCoroutine(BananaStopThisRound());
                            isBananaStopP4 = false;
                        }
                        break;
                }
            }
        }
    }
    IEnumerator StopThisRound()
    {
        isStopUI--;
        DiceUIControl.isDiceUI = false;
        systemText.text = "此回合暫停";
        SystemTestTextControl.isTimer = true;
        yield return new WaitForSeconds(2f);
        ChangeCameraControl.changeCameraNum++;
        DiceUIControl.isDiceUI = true;
    }
    IEnumerator BombStopThisRound()
    {
        isBombStopUI--;
        DiceUIControl.isDiceUI = false;
        systemText.text = "此回合暫停";
        SystemTestTextControl.isTimer = true;
        yield return new WaitForSeconds(2f);
        ChangeCameraControl.changeCameraNum++;
        DiceUIControl.isDiceUI = true;
    }
    IEnumerator CowPowerStopThisRound()
    {
        isCowPowerStopUI--;
        DiceUIControl.isDiceUI = false;
        systemText.text = "此回合暫停";
        SystemTestTextControl.isTimer = true;
        yield return new WaitForSeconds(2f);
        ChangeCameraControl.changeCameraNum++;
        DiceUIControl.isDiceUI = true;
    }
    IEnumerator SnakePowerStopThisRound()
    {
        isSnakePowerStopUI--;
        DiceUIControl.isDiceUI = false;
        systemText.text = "此回合暫停";
        SystemTestTextControl.isTimer = true;
        yield return new WaitForSeconds(2f);
        ChangeCameraControl.changeCameraNum++;
        DiceUIControl.isDiceUI = true;
    }
    IEnumerator BananaStopThisRound()
    {
        isBananaStopUI--;
        DiceUIControl.isDiceUI = false;
        systemText.text = "此回合暫停";
        SystemTestTextControl.isTimer = true;
        yield return new WaitForSeconds(2f);
        ChangeCameraControl.changeCameraNum++;
        DiceUIControl.isDiceUI = true;
    }

    void AnimalsConfusion()
    {
        if (EventControl.isStopP1 || isBombStopP1 || CowPowerControl.isCowPowerStopP1 || isPoisonStopP1 || isBananaStopP1)
        {
            AnimatorControl.isP1Confusion = true;
        }
        else if (!EventControl.isStopP1 && !isBombStopP1 && !CowPowerControl.isCowPowerStopP1 && !isPoisonStopP1 && !isBananaStopP1)
        {
            AnimatorControl.isP1Confusion = false;
        }

        if (EventControl.isStopP2 || isBombStopP2 || CowPowerControl.isCowPowerStopP2 || isPoisonStopP2 || isBananaStopP2)
        {
            AnimatorControl.isP2Confusion = true;
        }
        else if (!EventControl.isStopP2 && !isBombStopP2 && !CowPowerControl.isCowPowerStopP2 && !isPoisonStopP2 && !isBananaStopP2)
        {
            AnimatorControl.isP2Confusion = false;
        }

        if (EventControl.isStopP3 || isBombStopP3 || CowPowerControl.isCowPowerStopP3 || isPoisonStopP3 || isBananaStopP3)
        {
            AnimatorControl.isP3Confusion = true;
        }
        else if (!EventControl.isStopP3 && !isBombStopP3 && !CowPowerControl.isCowPowerStopP3 && !isPoisonStopP3 && !isBananaStopP3)
        {
            AnimatorControl.isP3Confusion = false;
        }

        if (EventControl.isStopP4 || isBombStopP4 || CowPowerControl.isCowPowerStopP4 || isPoisonStopP4 || isBananaStopP4)
        {
            AnimatorControl.isP4Confusion = true;
        }
        else if (!EventControl.isStopP4 && !isBombStopP4 && !CowPowerControl.isCowPowerStopP4 && !isPoisonStopP4 && !isBananaStopP4)
        {
            AnimatorControl.isP4Confusion = false;
        }
    }
}
