using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PropsControl : MonoBehaviour
{
    public static string[] propsName = new string[7];
    public static int[] P1Props = new int[7];
    public static int[] P2Props = new int[7];
    public static int[] P3Props = new int[7];
    public static int[] P4Props = new int[7];
    public static int isTransNum = 0;
    public static bool isTrans = false;

    public Text[] PropsQuantity = new Text[7];
    public Text systemText;

    int stealWho, totalNum; 
    int dicePropsNum = 1, propsNum = 0;
    bool isStealProps;
    bool[] isHavePropsP1 = new bool[7];
    bool[] isHavePropsP2 = new bool[7];
    bool[] isHavePropsP3 = new bool[7];
    bool[] isHavePropsP4 = new bool[7];

    void Start()
    {
        Initial();
    }
    void FixedUpdate()
    {
        HaveProps();
    }

    void Update()
    {
        switch (ChangeCameraControl.changeCameraNum)
        {
            case 1:
                PropsQuantity[0].text = P1Props[0].ToString();
                PropsQuantity[1].text = P1Props[1].ToString();
                PropsQuantity[2].text = P1Props[2].ToString();
                PropsQuantity[3].text = P1Props[3].ToString();
                PropsQuantity[4].text = P1Props[4].ToString();
                PropsQuantity[5].text = P1Props[5].ToString();
                PropsQuantity[6].text = P1Props[6].ToString();
                break;

            case 2:
                PropsQuantity[0].text = P2Props[0].ToString();
                PropsQuantity[1].text = P2Props[1].ToString();
                PropsQuantity[2].text = P2Props[2].ToString();
                PropsQuantity[3].text = P2Props[3].ToString();
                PropsQuantity[4].text = P2Props[4].ToString();
                PropsQuantity[5].text = P2Props[5].ToString();
                PropsQuantity[6].text = P2Props[6].ToString();
                break;

            case 3:
                PropsQuantity[0].text = P3Props[0].ToString();
                PropsQuantity[1].text = P3Props[1].ToString();
                PropsQuantity[2].text = P3Props[2].ToString();
                PropsQuantity[3].text = P3Props[3].ToString();
                PropsQuantity[4].text = P3Props[4].ToString();
                PropsQuantity[5].text = P3Props[5].ToString();
                PropsQuantity[6].text = P3Props[6].ToString();
                break;

            case 4:
                PropsQuantity[0].text = P4Props[0].ToString();
                PropsQuantity[1].text = P4Props[1].ToString();
                PropsQuantity[2].text = P4Props[2].ToString();
                PropsQuantity[3].text = P4Props[3].ToString();
                PropsQuantity[4].text = P4Props[4].ToString();
                PropsQuantity[5].text = P4Props[5].ToString();
                PropsQuantity[6].text = P4Props[6].ToString();
                break;
        }

        if (BagUIControl.isSnatch)
        {
            switch (ChangeCameraControl.changeCameraNum)
            {
                case 1:
                    stealWho = Random.Range(1, Menu_ChoosePlayer.whoPlay);
                    AnimatorControl.isP1Win = true;
                    switch (stealWho)
                    {
                        case 1:
                            for (int i = 0; i < 7; i++)
                            {
                                if (isHavePropsP2[i])
                                {
                                    if (!AnimalsPowerControl.chickenUsePower || Menu_ChoosePlayer.whyP2 != 10)
                                    {
                                        P2Props[i]--;
                                        P1Props[i]++;
                                        isStealProps = true;
                                        systemText.text = "偷走" + RoundUIControl.Player[2].ToString() + "的" + propsName[i].ToString();
                                        systemText.fontSize = 15;
                                        SystemTestTextControl.isTimer = true;
                                    }
                                    else 
                                    {
                                        systemText.text = "雞處於無敵狀態，偷盜失敗";
                                        systemText.fontSize = 15;
                                        SystemTestTextControl.isTimer = true;
                                    }
                                    break;
                                }
                            }
                            break;

                        case 2:
                            for (int i = 0; i < 7; i++)
                            {
                                if (isHavePropsP3[i])
                                {
                                    if (!AnimalsPowerControl.chickenUsePower || Menu_ChoosePlayer.whyP3 != 10)
                                    {
                                        P3Props[i]--;
                                        P1Props[i]++;
                                        isStealProps = true;
                                        systemText.text = "偷走" + RoundUIControl.Player[3].ToString() + "的" + propsName[i].ToString();
                                        systemText.fontSize = 15;
                                        SystemTestTextControl.isTimer = true;
                                    }
                                    else 
                                    {
                                        systemText.text = "雞處於無敵狀態，偷盜失敗";
                                        systemText.fontSize = 15;
                                        SystemTestTextControl.isTimer = true;
                                    }
                                    break;
                                }
                            }
                            break;

                        case 3:
                            for (int i = 0; i < 7; i++)
                            {
                                if (isHavePropsP4[i])
                                {
                                    if (!AnimalsPowerControl.chickenUsePower || Menu_ChoosePlayer.whyP4 != 10)
                                    {
                                        P4Props[i]--;
                                        P1Props[i]++;
                                        isStealProps = true;
                                        systemText.text = "偷走" + RoundUIControl.Player[4].ToString() + "的" + propsName[i].ToString();
                                        systemText.fontSize = 15;
                                        SystemTestTextControl.isTimer = true;
                                    }
                                    else
                                    {
                                        systemText.text = "雞處於無敵狀態，偷盜失敗";
                                        systemText.fontSize = 15;
                                        SystemTestTextControl.isTimer = true;
                                    }
                                    break;
                                }
                            }
                            break;
                    }
                    if (!isStealProps)
                    {
                        systemText.text = "對方沒有道具可偷";
                        systemText.fontSize = 15;
                        SystemTestTextControl.isTimer = true;
                        break;
                    }
                    else
                    {
                        isStealProps = false;
                    }
                    break;

                case 2:
                    stealWho = Random.Range(1, Menu_ChoosePlayer.whoPlay);
                    AnimatorControl.isP2Win = true;
                    switch (stealWho)
                    {
                        case 1:
                            for (int i = 0; i < 7; i++)
                            {
                                if (isHavePropsP1[i])
                                {
                                    if (!AnimalsPowerControl.chickenUsePower || Menu_ChoosePlayer.whyP1 != 10)
                                    {
                                        P1Props[i]--;
                                        P2Props[i]++;
                                        isStealProps = true;
                                        systemText.text = "偷走" + RoundUIControl.Player[1].ToString() + "的" + propsName[i].ToString();
                                        systemText.fontSize = 15;
                                        SystemTestTextControl.isTimer = true;
                                        break;
                                    }
                                    else
                                    {
                                        systemText.text = "雞處於無敵狀態，偷盜失敗";
                                        systemText.fontSize = 15;
                                        SystemTestTextControl.isTimer = true;
                                    }
                                }
                            }
                            break;

                        case 2:
                            for (int i = 0; i < 7; i++)
                            {
                                if (isHavePropsP3[i])
                                {
                                    if (!AnimalsPowerControl.chickenUsePower || Menu_ChoosePlayer.whyP3 != 10)
                                    {
                                        P3Props[i]--;
                                        P2Props[i]++;
                                        isStealProps = true;
                                        systemText.text = "偷走" + RoundUIControl.Player[3].ToString() + "的" + propsName[i].ToString();
                                        systemText.fontSize = 15;
                                        SystemTestTextControl.isTimer = true;
                                    }
                                    else
                                    {
                                        systemText.text = "雞處於無敵狀態，偷盜失敗";
                                        systemText.fontSize = 15;
                                        SystemTestTextControl.isTimer = true;
                                    }
                                    break;
                                }
                            }
                            break;

                        case 3:
                            for (int i = 0; i < 7; i++)
                            {
                                if (isHavePropsP4[i])
                                {
                                    if (!AnimalsPowerControl.chickenUsePower || Menu_ChoosePlayer.whyP4 != 10)
                                    {
                                        P4Props[i]--;
                                        P2Props[i]++;
                                        isStealProps = true;
                                        systemText.text = "偷走" + RoundUIControl.Player[4].ToString() + "的" + propsName[i].ToString();
                                        systemText.fontSize = 15;
                                        SystemTestTextControl.isTimer = true;
                                    }
                                    else
                                    {
                                        systemText.text = "雞處於無敵狀態，偷盜失敗";
                                        systemText.fontSize = 15;
                                        SystemTestTextControl.isTimer = true;
                                    }
                                    break;
                                }
                            }
                            break;
                    }
                    if (!isStealProps)
                    {
                        systemText.text = "對方沒有道具可偷";
                        systemText.fontSize = 15;
                        SystemTestTextControl.isTimer = true;
                        break;
                    }
                    else
                    {
                        isStealProps = false;
                    }
                    break;

                case 3:
                    stealWho = Random.Range(1, Menu_ChoosePlayer.whoPlay);
                    AnimatorControl.isP3Win = true;
                    switch (stealWho)
                    {
                        case 1:
                            for (int i = 0; i < 7; i++)
                            {
                                if (isHavePropsP1[i])
                                {
                                    if (!AnimalsPowerControl.chickenUsePower || Menu_ChoosePlayer.whyP1 != 10)
                                    {
                                        P1Props[i]--;
                                        P3Props[i]++;
                                        isStealProps = true;
                                        systemText.text = "偷走" + RoundUIControl.Player[1].ToString() + "的" + propsName[i].ToString();
                                        systemText.fontSize = 15;
                                        SystemTestTextControl.isTimer = true;
                                    }
                                    else
                                    {
                                        systemText.text = "雞處於無敵狀態，偷盜失敗";
                                        systemText.fontSize = 15;
                                        SystemTestTextControl.isTimer = true;
                                    }
                                    break;
                                }
                            }
                            break;

                        case 2:
                            for (int i = 0; i < 7; i++)
                            {
                                if (isHavePropsP2[i])
                                {
                                    if (!AnimalsPowerControl.chickenUsePower || Menu_ChoosePlayer.whyP2 != 10)
                                    {
                                        P2Props[i]--;
                                        P3Props[i]++;
                                        isStealProps = true;
                                        systemText.text = "偷走" + RoundUIControl.Player[2].ToString() + "的" + propsName[i].ToString();
                                        systemText.fontSize = 15;
                                        SystemTestTextControl.isTimer = true;
                                    }
                                    else
                                    {
                                        systemText.text = "雞處於無敵狀態，偷盜失敗";
                                        systemText.fontSize = 15;
                                        SystemTestTextControl.isTimer = true;
                                    }
                                    break;
                                }
                            }
                            break;

                        case 3:
                            for (int i = 0; i < 7; i++)
                            {
                                if (isHavePropsP4[i])
                                {
                                    if (!AnimalsPowerControl.chickenUsePower || Menu_ChoosePlayer.whyP4 != 10)
                                    {
                                        P4Props[i]--;
                                        P3Props[i]++;
                                        isStealProps = true;
                                        systemText.text = "偷走" + RoundUIControl.Player[4].ToString() + "的" + propsName[i].ToString();
                                        systemText.fontSize = 15;
                                        SystemTestTextControl.isTimer = true;
                                    }
                                    else
                                    {
                                        systemText.text = "雞處於無敵狀態，偷盜失敗";
                                        systemText.fontSize = 15;
                                        SystemTestTextControl.isTimer = true;
                                    }
                                    break;
                                }
                            }
                            break;
                    }
                    if (!isStealProps)
                    {
                        systemText.text = "對方沒有道具可偷";
                        systemText.fontSize = 15;
                        SystemTestTextControl.isTimer = true;
                        break;
                    }
                    else
                    {
                        isStealProps = false;
                    }
                    break;

                case 4:
                    stealWho = Random.Range(1, Menu_ChoosePlayer.whoPlay);
                    AnimatorControl.isP4Win = true;
                    switch (stealWho)
                    {
                        case 1:
                            for (int i = 0; i < 7; i++)
                            {
                                if (isHavePropsP1[i])
                                {
                                    if (!AnimalsPowerControl.chickenUsePower || Menu_ChoosePlayer.whyP1 != 10)
                                    {
                                        P1Props[i]--;
                                        P4Props[i]++;
                                        isStealProps = true;
                                        systemText.text = "偷走" + RoundUIControl.Player[1].ToString() + "的" + propsName[i].ToString();
                                        systemText.fontSize = 15;
                                        SystemTestTextControl.isTimer = true;
                                    }
                                    else
                                    {
                                        systemText.text = "雞處於無敵狀態，偷盜失敗";
                                        systemText.fontSize = 15;
                                        SystemTestTextControl.isTimer = true;
                                    }
                                    break;
                                }
                            }
                            break;

                        case 2:
                            for (int i = 0; i < 7; i++)
                            {
                                if (isHavePropsP2[i])
                                {
                                    if (!AnimalsPowerControl.chickenUsePower || Menu_ChoosePlayer.whyP2 != 10)
                                    {
                                        P2Props[i]--;
                                        P4Props[i]++;
                                        isStealProps = true;
                                        systemText.text = "偷走" + RoundUIControl.Player[2].ToString() + "的" + propsName[i].ToString();
                                        systemText.fontSize = 15;
                                        SystemTestTextControl.isTimer = true;
                                    }
                                    else
                                    {
                                        systemText.text = "雞處於無敵狀態，偷盜失敗";
                                        systemText.fontSize = 15;
                                        SystemTestTextControl.isTimer = true;
                                    }
                                    break;
                                }
                            }
                            break;

                        case 3:
                            for (int i = 0; i < 7; i++)
                            {
                                if (isHavePropsP3[i])
                                {
                                    if (!AnimalsPowerControl.chickenUsePower || Menu_ChoosePlayer.whyP3 != 10)
                                    {
                                        P3Props[i]--;
                                        P4Props[i]++;
                                        isStealProps = true;
                                        systemText.text = "偷走" + RoundUIControl.Player[3].ToString() + "的" + propsName[i].ToString();
                                        systemText.fontSize = 15;
                                        SystemTestTextControl.isTimer = true;
                                    }
                                    else
                                    {
                                        systemText.text = "雞處於無敵狀態，偷盜失敗";
                                        systemText.fontSize = 15;
                                        SystemTestTextControl.isTimer = true;
                                    }
                                    break;
                                }
                            }
                            break;
                    }
                    if (!isStealProps)
                    {
                        systemText.text = "對方沒有道具可偷";
                        systemText.fontSize = 15;
                        SystemTestTextControl.isTimer = true;
                        break;
                    }
                    else
                    {
                        isStealProps = false;
                    }
                    break;
            }
            BagUIControl.isSnatch = false;
            Invoke("FalseByAnimator", 1f);
        }

        if (BagUIControl.isTransposition)
        {
            isTransNum = 0;
            isTrans = true;
            switch (ChangeCameraControl.changeCameraNum)
            {
                case 1:
                    stealWho = Random.Range(1, Menu_ChoosePlayer.whoPlay);
                    switch (stealWho)
                    {
                        case 1:
                            if (!AnimalsPowerControl.chickenUsePower || Menu_ChoosePlayer.whyP2 != 10)
                            {
                                if (DiceControl.P1_totalNum != DiceControl.P2_totalNum)
                                {
                                    systemText.text = "和" + RoundUIControl.Player[2].ToString() + "換位";
                                    SystemTestTextControl.isTimer = true;
                                    AnimatorControl.isP1Move = true;
                                    AnimatorControl.isP2Move = true;
                                    totalNum = DiceControl.P1_totalNum;
                                    DiceControl.P1_totalNum = DiceControl.P2_totalNum;
                                    DiceControl.P2_totalNum = totalNum;
                                }
                                else
                                {
                                    systemText.text = "和" + RoundUIControl.Player[2].ToString() + "在同一個位置上";
                                    SystemTestTextControl.isTimer = true;
                                    Invoke("WaitTransNum", 2f);
                                }
                            }
                            else
                            {
                                systemText.text = "雞處於無敵狀態，換位失敗";
                                SystemTestTextControl.isTimer = true;
                                Invoke("WaitTransNum", 2f);
                            }
                            break;

                        case 2:
                            if (!AnimalsPowerControl.chickenUsePower || Menu_ChoosePlayer.whyP3 != 10)
                            {
                                if (DiceControl.P1_totalNum != DiceControl.P3_totalNum)
                                {
                                    systemText.text = "和" + RoundUIControl.Player[3].ToString() + "換位";
                                    SystemTestTextControl.isTimer = true;
                                    AnimatorControl.isP1Move = true;
                                    AnimatorControl.isP3Move = true;
                                    totalNum = DiceControl.P1_totalNum;
                                    DiceControl.P1_totalNum = DiceControl.P3_totalNum;
                                    DiceControl.P3_totalNum = totalNum;
                                }
                                else
                                {
                                    systemText.text = "和" + RoundUIControl.Player[3].ToString() + "在同一個位置上";
                                    SystemTestTextControl.isTimer = true;
                                    Invoke("WaitTransNum", 2f);
                                }
                            }
                            else
                            {
                                systemText.text = "雞處於無敵狀態，換位失敗";
                                SystemTestTextControl.isTimer = true;
                                Invoke("WaitTransNum", 2f);
                            }
                            break;

                        case 3:
                            if (!AnimalsPowerControl.chickenUsePower || Menu_ChoosePlayer.whyP4 != 10)
                            {
                                if (DiceControl.P1_totalNum != DiceControl.P4_totalNum)
                                {
                                    systemText.text = "和" + RoundUIControl.Player[4].ToString() + "換位";
                                    SystemTestTextControl.isTimer = true;
                                    AnimatorControl.isP1Move = true;
                                    AnimatorControl.isP4Move = true;
                                    totalNum = DiceControl.P1_totalNum;
                                    DiceControl.P1_totalNum = DiceControl.P4_totalNum;
                                    DiceControl.P4_totalNum = totalNum;
                                }
                                else
                                {
                                    systemText.text = "和" + RoundUIControl.Player[4].ToString() + "在同一個位置上";
                                    SystemTestTextControl.isTimer = true;
                                    Invoke("WaitTransNum", 2f);
                                }
                            }
                            else
                            {
                                systemText.text = "雞處於無敵狀態，換位失敗";
                                SystemTestTextControl.isTimer = true;
                                Invoke("WaitTransNum", 2f);
                            }
                            break;
                    }
                    break;

                case 2:
                    stealWho = Random.Range(1, Menu_ChoosePlayer.whoPlay);
                    switch (stealWho)
                    {
                        case 1:
                            if (!AnimalsPowerControl.chickenUsePower || Menu_ChoosePlayer.whyP1 != 10)
                            {
                                if (DiceControl.P2_totalNum != DiceControl.P1_totalNum)
                                {
                                    systemText.text = "和" + RoundUIControl.Player[1].ToString() + "換位";
                                    SystemTestTextControl.isTimer = true;
                                    AnimatorControl.isP2Move = true;
                                    AnimatorControl.isP1Move = true;
                                    totalNum = DiceControl.P2_totalNum;
                                    DiceControl.P2_totalNum = DiceControl.P1_totalNum;
                                    DiceControl.P1_totalNum = totalNum;
                                }
                                else
                                {
                                    systemText.text = "和" + RoundUIControl.Player[1].ToString() + "在同一個位置上";
                                    SystemTestTextControl.isTimer = true;
                                    Invoke("WaitTransNum", 2f);
                                }
                            }
                            else
                            {
                                systemText.text = "雞處於無敵狀態，換位失敗";
                                SystemTestTextControl.isTimer = true;
                                Invoke("WaitTransNum", 2f);
                            }
                            break;

                        case 2:
                            if (!AnimalsPowerControl.chickenUsePower || Menu_ChoosePlayer.whyP3 != 10)
                            {
                                if (DiceControl.P2_totalNum != DiceControl.P3_totalNum)
                                {
                                    systemText.text = "和" + RoundUIControl.Player[3].ToString() + "換位";
                                    SystemTestTextControl.isTimer = true;
                                    AnimatorControl.isP2Move = true;
                                    AnimatorControl.isP3Move = true;
                                    totalNum = DiceControl.P2_totalNum;
                                    DiceControl.P2_totalNum = DiceControl.P3_totalNum;
                                    DiceControl.P3_totalNum = totalNum;
                                }
                                else
                                {
                                    systemText.text = "和" + RoundUIControl.Player[3].ToString() + "在同一個位置上";
                                    SystemTestTextControl.isTimer = true;
                                    Invoke("WaitTransNum", 2f);
                                }
                            }
                            else
                            {
                                systemText.text = "雞處於無敵狀態，換位失敗";
                                SystemTestTextControl.isTimer = true;
                                Invoke("WaitTransNum", 2f);
                            }
                            break;

                        case 3:
                            if (!AnimalsPowerControl.chickenUsePower || Menu_ChoosePlayer.whyP4 != 10)
                            {
                                if (DiceControl.P2_totalNum != DiceControl.P4_totalNum)
                                {
                                    systemText.text = "和" + RoundUIControl.Player[4].ToString() + "換位";
                                    SystemTestTextControl.isTimer = true;
                                    AnimatorControl.isP2Move = true;
                                    AnimatorControl.isP4Move = true;
                                    totalNum = DiceControl.P2_totalNum;
                                    DiceControl.P2_totalNum = DiceControl.P4_totalNum;
                                    DiceControl.P4_totalNum = totalNum;
                                }
                                else
                                {
                                    systemText.text = "和" + RoundUIControl.Player[4].ToString() + "在同一個位置上";
                                    SystemTestTextControl.isTimer = true;
                                    Invoke("WaitTransNum", 2f);
                                }
                            }
                            else
                            {
                                systemText.text = "雞處於無敵狀態，換位失敗";
                                SystemTestTextControl.isTimer = true;
                                Invoke("WaitTransNum", 2f);
                            }
                            break;
                    }
                    break;

                case 3:
                    stealWho = Random.Range(1, Menu_ChoosePlayer.whoPlay);
                    AnimatorControl.isP3Win = true;
                    switch (stealWho)
                    {
                        case 1:
                            if (!AnimalsPowerControl.chickenUsePower || Menu_ChoosePlayer.whyP1 != 10)
                            {
                                if (DiceControl.P3_totalNum != DiceControl.P1_totalNum)
                                {
                                    systemText.text = "和" + RoundUIControl.Player[1].ToString() + "換位";
                                    SystemTestTextControl.isTimer = true;
                                    AnimatorControl.isP3Move = true;
                                    AnimatorControl.isP1Move = true;
                                    totalNum = DiceControl.P3_totalNum;
                                    DiceControl.P3_totalNum = DiceControl.P1_totalNum;
                                    DiceControl.P1_totalNum = totalNum;
                                }
                                else
                                {
                                    systemText.text = "和" + RoundUIControl.Player[1].ToString() + "在同一個位置上";
                                    SystemTestTextControl.isTimer = true;
                                    Invoke("WaitTransNum", 2f);
                                }
                            }
                            else
                            {
                                systemText.text = "雞處於無敵狀態，換位失敗";
                                SystemTestTextControl.isTimer = true;
                                Invoke("WaitTransNum", 2f);
                            }
                            break;

                        case 2:
                            if (!AnimalsPowerControl.chickenUsePower || Menu_ChoosePlayer.whyP2 != 10)
                            {
                                if (DiceControl.P3_totalNum != DiceControl.P2_totalNum)
                                {
                                    systemText.text = "和" + RoundUIControl.Player[2].ToString() + "換位";
                                    SystemTestTextControl.isTimer = true;
                                    AnimatorControl.isP3Move = true;
                                    AnimatorControl.isP2Move = true;
                                    totalNum = DiceControl.P3_totalNum;
                                    DiceControl.P3_totalNum = DiceControl.P2_totalNum;
                                    DiceControl.P2_totalNum = totalNum;
                                }
                                else
                                {
                                    systemText.text = "和" + RoundUIControl.Player[2].ToString() + "在同一個位置上";
                                    SystemTestTextControl.isTimer = true;
                                    Invoke("WaitTransNum", 2f);
                                }
                            }
                            else
                            {
                                systemText.text = "雞處於無敵狀態，換位失敗";
                                SystemTestTextControl.isTimer = true;
                                Invoke("WaitTransNum", 2f);
                            }
                            break;

                        case 3:
                            if (!AnimalsPowerControl.chickenUsePower || Menu_ChoosePlayer.whyP4 != 10)
                            {
                                if (DiceControl.P3_totalNum != DiceControl.P4_totalNum)
                                {
                                    systemText.text = "和" + RoundUIControl.Player[4].ToString() + "換位";
                                    SystemTestTextControl.isTimer = true;
                                    AnimatorControl.isP3Move = true;
                                    AnimatorControl.isP4Move = true;
                                    totalNum = DiceControl.P3_totalNum;
                                    DiceControl.P3_totalNum = DiceControl.P4_totalNum;
                                    DiceControl.P4_totalNum = totalNum;
                                }
                                else
                                {
                                    systemText.text = "和" + RoundUIControl.Player[4].ToString() + "在同一個位置上";
                                    SystemTestTextControl.isTimer = true;
                                    Invoke("WaitTransNum", 2f);
                                }
                            }
                            else
                            {
                                systemText.text = "雞處於無敵狀態，換位失敗";
                                SystemTestTextControl.isTimer = true;
                                Invoke("WaitTransNum", 2f);
                            }
                            break;
                    }
                    break;

                case 4:
                    stealWho = Random.Range(1, Menu_ChoosePlayer.whoPlay);
                    AnimatorControl.isP4Win = true;
                    switch (stealWho)
                    {
                        case 1:
                            if (!AnimalsPowerControl.chickenUsePower || Menu_ChoosePlayer.whyP1 != 10)
                            {
                                if (DiceControl.P4_totalNum != DiceControl.P1_totalNum)
                                {
                                    systemText.text = "和" + RoundUIControl.Player[1].ToString() + "換位";
                                    SystemTestTextControl.isTimer = true;
                                    AnimatorControl.isP4Move = true;
                                    AnimatorControl.isP1Move = true;
                                    totalNum = DiceControl.P4_totalNum;
                                    DiceControl.P4_totalNum = DiceControl.P1_totalNum;
                                    DiceControl.P1_totalNum = totalNum;
                                }
                                else
                                {
                                    systemText.text = "和" + RoundUIControl.Player[1].ToString() + "在同一個位置上";
                                    SystemTestTextControl.isTimer = true;
                                    Invoke("WaitTransNum", 2f);
                                }
                            }
                            else
                            {
                                systemText.text = "雞處於無敵狀態，換位失敗";
                                SystemTestTextControl.isTimer = true;
                                Invoke("WaitTransNum", 2f);
                            }
                            break;

                        case 2:
                            if (!AnimalsPowerControl.chickenUsePower || Menu_ChoosePlayer.whyP2 != 10)
                            {
                                if (DiceControl.P4_totalNum != DiceControl.P2_totalNum)
                                {
                                    systemText.text = "和" + RoundUIControl.Player[2].ToString() + "換位";
                                    SystemTestTextControl.isTimer = true;
                                    AnimatorControl.isP4Move = true;
                                    AnimatorControl.isP2Move = true;
                                    totalNum = DiceControl.P4_totalNum;
                                    DiceControl.P4_totalNum = DiceControl.P2_totalNum;
                                    DiceControl.P2_totalNum = totalNum;
                                }
                                else
                                {
                                    systemText.text = "和" + RoundUIControl.Player[2].ToString() + "在同一個位置上";
                                    SystemTestTextControl.isTimer = true;
                                    Invoke("WaitTransNum", 2f);
                                }
                            }
                            else
                            {
                                systemText.text = "雞處於無敵狀態，換位失敗";
                                SystemTestTextControl.isTimer = true;
                                Invoke("WaitTransNum", 2f);
                            }
                            break;

                        case 3:
                            if (!AnimalsPowerControl.chickenUsePower || Menu_ChoosePlayer.whyP3 != 10)
                            {
                                if (DiceControl.P4_totalNum != DiceControl.P3_totalNum)
                                {
                                    systemText.text = "和" + RoundUIControl.Player[3].ToString() + "換位";
                                    SystemTestTextControl.isTimer = true;
                                    AnimatorControl.isP4Move = true;
                                    AnimatorControl.isP3Move = true;
                                    totalNum = DiceControl.P4_totalNum;
                                    DiceControl.P4_totalNum = DiceControl.P3_totalNum;
                                    DiceControl.P3_totalNum = totalNum;
                                }
                                else
                                {
                                    systemText.text = "和" + RoundUIControl.Player[3].ToString() + "在同一個位置上";
                                    SystemTestTextControl.isTimer = true;
                                    Invoke("WaitTransNum", 2f);
                                }
                            }
                            else
                            {
                                systemText.text = "雞處於無敵狀態，換位失敗";
                                SystemTestTextControl.isTimer = true;
                                Invoke("WaitTransNum", 2f);
                            }
                            break;
                    }
                    break;
            }
            BagUIControl.isTransposition = false;
        }

        if (isTransNum >= 2)
        {
            isTransNum = 0;
            isTrans = false;
            DiceUIControl.isDiceUI = true;
            ChangeCameraControl.changeCameraNum++;
        }

        if (BombPropsControl.iscolliderBombText)
        {
            systemText.text = "踩到炸彈";
            SystemTestTextControl.isTimer = true;
            BombPropsControl.iscolliderBombText = false;
        }

        if (BananaControl.iscolliderBananaText)
        {
            StartCoroutine(ColliderBanana());
        }

        CheatDevice();
    }

    void Initial()
    {
        for (int a = 0; a < 3; a++)
        {
            P1Props[a] = dicePropsNum;
            P2Props[a] = dicePropsNum;
            P3Props[a] = dicePropsNum;
            P4Props[a] = dicePropsNum;
        }
        for (int b = 3; b < 7; b++)
        {
            P1Props[b] = propsNum;
            P2Props[b] = propsNum;
            P3Props[b] = propsNum;
            P4Props[b] = propsNum;
        }
        propsName[0] = "重來骰子";
        propsName[1] = "雙倍骰子";
        propsName[2] = "自訂骰子";
        propsName[3] = "定格炸彈";
        propsName[4] = "搶奪魔杖";
        propsName[5] = "換位魔杖";
        propsName[6] = "黃金竊手";
    }
    void HaveProps()
    {
        for (int i = 0; i < 7; i++)
        {
            if (P1Props[i] != 0)
            {
                isHavePropsP1[i] = true;
            }
            else
            {
                isHavePropsP1[i] = false;
            }

            if (P2Props[i] != 0)
            {
                isHavePropsP2[i] = true;
            }
            else
            {
                isHavePropsP2[i] = false;
            }

            if (P3Props[i] != 0)
            {
                isHavePropsP3[i] = true;
            }
            else
            {
                isHavePropsP3[i] = false;
            }

            if (P4Props[i] != 0)
            {
                isHavePropsP4[i] = true;
            }
            else
            {
                isHavePropsP4[i] = false;
            }
        }
    }
    void FalseByAnimator()
    {
        AnimatorControl.isP1Win = false;
        AnimatorControl.isP2Win = false;
        AnimatorControl.isP3Win = false;
        AnimatorControl.isP4Win = false;
    }
    void WaitTransNum()
    {
        isTransNum = 2;
    }
    void CheatDevice()
    {
        if (Input.GetKey(KeyCode.LeftShift))
        {
            if (Input.GetKeyDown(KeyCode.P))
            {
                switch (ChangeCameraControl.changeCameraNum)
                {
                    case 1:
                        for (int i = 0; i < 7; i++)
                        {
                            P1Props[i] += 1;
                        }
                        break;

                    case 2:
                        for (int i = 0; i < 7; i++)
                        {
                            P2Props[i] += 1;
                        }
                        break;

                    case 3:
                        for (int i = 0; i < 7; i++)
                        {
                            P3Props[i] += 1;
                        }
                        break;

                    case 4:
                        for (int i = 0; i < 7; i++)
                        {
                            P4Props[i] += 1;
                        }
                        break;
                }
            }

            if (Input.GetKeyDown(KeyCode.O))
            {
                switch (ChangeCameraControl.changeCameraNum)
                {
                    case 1:
                        P1Props[2] += 1;
                        break;

                    case 2:
                        P2Props[2] += 1;
                        break;

                    case 3:
                        P3Props[2] += 1;
                        break;

                    case 4:
                        P4Props[2] += 1;
                        break;
                }
            }
        }
    }

    IEnumerator ColliderBanana()
    {
        BananaControl.iscolliderBananaText = false;
        systemText.text = "踩到香蕉";
        SystemTestTextControl.isTimer = true;
        yield return new WaitForSeconds(2f);
        systemText.text = "身上道具全沒了";
        SystemTestTextControl.isTimer = true;
        if (IsStopUIControl.isBananaStopP1)
        {
            for (int i = 0; i < 7; i++)
            {
                P1Props[i] = 0;
            }
        }
        else if (IsStopUIControl.isBananaStopP2)
        {
            for (int i = 0; i < 7; i++)
            {
                P2Props[i] = 0;
            }
        }
        else if (IsStopUIControl.isBananaStopP3)
        {
            for (int i = 0; i < 7; i++)
            {
                P3Props[i] = 0;
            }
        }
        else if (IsStopUIControl.isBananaStopP4)
        {
            for (int i = 0; i < 7; i++)
            {
                P4Props[i] = 0;
            }
        }
    }
}
