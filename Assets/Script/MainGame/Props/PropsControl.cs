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
    public static bool isTrans = false;

    public Text[] PropsQuantity = new Text[7];
    public Text systemText;

    int stealWho, totalNum;
    bool isStealProps;
    bool[] isHavePropsP1 = new bool[7];
    bool[] isHavePropsP2 = new bool[7];
    bool[] isHavePropsP3 = new bool[7];
    bool[] isHavePropsP4 = new bool[7];
    Vector3 transposition;
    GameObject P1, P2, P3, P4;

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
                                    P2Props[i]--;
                                    P1Props[i]++;
                                    isStealProps = true;
                                    systemText.text = "偷走" + RoundUIControl.Player[2].ToString() + "的" + propsName[i].ToString();
                                    systemText.fontSize = 15;
                                    SystemTestTextControl.isTimer = true;
                                    break;
                                }
                            }
                            break;

                        case 2:
                            for (int i = 0; i < 7; i++)
                            {
                                if (isHavePropsP3[i])
                                {
                                    P3Props[i]--;
                                    P1Props[i]++;
                                    isStealProps = true;
                                    systemText.text = "偷走" + RoundUIControl.Player[3].ToString() + "的" + propsName[i].ToString();
                                    systemText.fontSize = 15;
                                    SystemTestTextControl.isTimer = true;
                                    break;
                                }
                            }
                            break;

                        case 3:
                            for (int i = 0; i < 7; i++)
                            {
                                if (isHavePropsP4[i])
                                {
                                    P4Props[i]--;
                                    P1Props[i]++;
                                    isStealProps = true;
                                    systemText.text = "偷走" + RoundUIControl.Player[4].ToString() + "的" + propsName[i].ToString();
                                    systemText.fontSize = 15;
                                    SystemTestTextControl.isTimer = true;
                                    break;
                                }
                            }
                            break;
                    }
                    if (!isStealProps)
                    {
                        systemText.text = "偷盜失敗！";
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
                                    P1Props[i]--;
                                    P2Props[i]++;
                                    isStealProps = true;
                                    systemText.text = "偷走" + RoundUIControl.Player[1].ToString() + "的" + propsName[i].ToString();
                                    systemText.fontSize = 15;
                                    SystemTestTextControl.isTimer = true;
                                    break;
                                }
                            }
                            break;

                        case 2:
                            for (int i = 0; i < 7; i++)
                            {
                                if (isHavePropsP3[i])
                                {
                                    P3Props[i]--;
                                    P2Props[i]++;
                                    isStealProps = true;
                                    systemText.text = "偷走" + RoundUIControl.Player[3].ToString() + "的" + propsName[i].ToString();
                                    systemText.fontSize = 15;
                                    SystemTestTextControl.isTimer = true;
                                    break;
                                }
                            }
                            break;

                        case 3:
                            for (int i = 0; i < 7; i++)
                            {
                                if (isHavePropsP4[i])
                                {
                                    P4Props[i]--;
                                    P2Props[i]++;
                                    isStealProps = true;
                                    systemText.text = "偷走" + RoundUIControl.Player[4].ToString() + "的" + propsName[i].ToString();
                                    systemText.fontSize = 15;
                                    SystemTestTextControl.isTimer = true;
                                    break;
                                }
                            }
                            break;
                    }
                    if (!isStealProps)
                    {
                        systemText.text = "偷盜失敗！";
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
                                    P1Props[i]--;
                                    P3Props[i]++;
                                    isStealProps = true;
                                    systemText.text = "偷走" + RoundUIControl.Player[1].ToString() + "的" + propsName[i].ToString();
                                    systemText.fontSize = 15;
                                    SystemTestTextControl.isTimer = true;
                                    break;
                                }
                            }
                            break;

                        case 2:
                            for (int i = 0; i < 7; i++)
                            {
                                if (isHavePropsP2[i])
                                {
                                    P2Props[i]--;
                                    P3Props[i]++;
                                    isStealProps = true;
                                    systemText.text = "偷走" + RoundUIControl.Player[2].ToString() + "的" + propsName[i].ToString();
                                    systemText.fontSize = 15;
                                    SystemTestTextControl.isTimer = true;
                                    break;
                                }
                            }
                            break;

                        case 3:
                            for (int i = 0; i < 7; i++)
                            {
                                if (isHavePropsP4[i])
                                {
                                    P4Props[i]--;
                                    P3Props[i]++;
                                    isStealProps = true;
                                    systemText.text = "偷走" + RoundUIControl.Player[4].ToString() + "的" + propsName[i].ToString();
                                    systemText.fontSize = 15;
                                    SystemTestTextControl.isTimer = true;
                                    break;
                                }
                            }
                            break;
                    }
                    if (!isStealProps)
                    {
                        systemText.text = "偷盜失敗！";
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
                                    P1Props[i]--;
                                    P4Props[i]++;
                                    isStealProps = true;
                                    systemText.text = "偷走" + RoundUIControl.Player[1].ToString() + "的" + propsName[i].ToString();
                                    systemText.fontSize = 15;
                                    SystemTestTextControl.isTimer = true;
                                    break;
                                }
                            }
                            break;

                        case 2:
                            for (int i = 0; i < 7; i++)
                            {
                                if (isHavePropsP2[i])
                                {
                                    P2Props[i]--;
                                    P4Props[i]++;
                                    isStealProps = true;
                                    systemText.text = "偷走" + RoundUIControl.Player[2].ToString() + "的" + propsName[i].ToString();
                                    systemText.fontSize = 15;
                                    SystemTestTextControl.isTimer = true;
                                    break;
                                }
                            }
                            break;

                        case 3:
                            for (int i = 0; i < 7; i++)
                            {
                                if (isHavePropsP3[i])
                                {
                                    P3Props[i]--;
                                    P4Props[i]++;
                                    isStealProps = true;
                                    systemText.text = "偷走" + RoundUIControl.Player[3].ToString() + "的" + propsName[i].ToString();
                                    systemText.fontSize = 15;
                                    SystemTestTextControl.isTimer = true;
                                    break;
                                }
                            }
                            break;
                    }
                    if (!isStealProps)
                    {
                        systemText.text = "偷盜失敗！";
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
            FindPlayer();
            isTrans = true;
            switch (ChangeCameraControl.changeCameraNum)
            {
                case 1:
                    stealWho = Random.Range(1, Menu_ChoosePlayer.whoPlay);
                    AnimatorControl.isP1Win = true;
                    switch (stealWho)
                    {
                        case 1:
                            transposition = P1.transform.position;
                            P1.transform.position = P2.transform.position;
                            P2.transform.position = transposition;

                            totalNum = DiceControl.P1_totalNum;
                            DiceControl.P1_totalNum = DiceControl.P2_totalNum;
                            DiceControl.P2_totalNum = totalNum;
                            break;

                        case 2:
                            transposition = P1.transform.position;
                            P1.transform.position = P3.transform.position;
                            P3.transform.position = transposition;

                            totalNum = DiceControl.P1_totalNum;
                            DiceControl.P1_totalNum = DiceControl.P3_totalNum;
                            DiceControl.P3_totalNum = totalNum;
                            break;

                        case 3:
                            transposition = P1.transform.position;
                            P1.transform.position = P4.transform.position;
                            P4.transform.position = transposition;

                            totalNum = DiceControl.P1_totalNum;
                            DiceControl.P1_totalNum = DiceControl.P4_totalNum;
                            DiceControl.P4_totalNum = totalNum;
                            break;
                    }
                    break;

                case 2:
                    stealWho = Random.Range(1, Menu_ChoosePlayer.whoPlay);
                    AnimatorControl.isP2Win = true;
                    switch (stealWho)
                    {
                        case 1:
                            transposition = P2.transform.position;
                            P2.transform.position = P1.transform.position;
                            P1.transform.position = transposition;

                            totalNum = DiceControl.P2_totalNum;
                            DiceControl.P2_totalNum = DiceControl.P1_totalNum;
                            DiceControl.P1_totalNum = totalNum;
                            break;

                        case 2:
                            transposition = P2.transform.position;
                            P2.transform.position = P3.transform.position;
                            P3.transform.position = transposition;

                            totalNum = DiceControl.P2_totalNum;
                            DiceControl.P2_totalNum = DiceControl.P3_totalNum;
                            DiceControl.P3_totalNum = totalNum;
                            break;

                        case 3:
                            transposition = P2.transform.position;
                            P2.transform.position = P4.transform.position;
                            P4.transform.position = transposition;

                            totalNum = DiceControl.P2_totalNum;
                            DiceControl.P2_totalNum = DiceControl.P4_totalNum;
                            DiceControl.P4_totalNum = totalNum;
                            break;
                    }
                    break;

                case 3:
                    stealWho = Random.Range(1, Menu_ChoosePlayer.whoPlay);
                    AnimatorControl.isP3Win = true;
                    switch (stealWho)
                    {
                        case 1:
                            transposition = P3.transform.position;
                            P3.transform.position = P1.transform.position;
                            P1.transform.position = transposition;

                            totalNum = DiceControl.P3_totalNum;
                            DiceControl.P3_totalNum = DiceControl.P1_totalNum;
                            DiceControl.P1_totalNum = totalNum;
                            break;

                        case 2:
                            transposition = P3.transform.position;
                            P3.transform.position = P2.transform.position;
                            P2.transform.position = transposition;

                            totalNum = DiceControl.P3_totalNum;
                            DiceControl.P3_totalNum = DiceControl.P2_totalNum;
                            DiceControl.P2_totalNum = totalNum;
                            break;

                        case 3:
                            transposition = P3.transform.position;
                            P3.transform.position = P4.transform.position;
                            P4.transform.position = transposition;

                            totalNum = DiceControl.P3_totalNum;
                            DiceControl.P3_totalNum = DiceControl.P4_totalNum;
                            DiceControl.P4_totalNum = totalNum;
                            break;
                    }
                    break;

                case 4:
                    stealWho = Random.Range(1, Menu_ChoosePlayer.whoPlay);
                    AnimatorControl.isP4Win = true;
                    switch (stealWho)
                    {
                        case 1:
                            transposition = P4.transform.position;
                            P4.transform.position = P1.transform.position;
                            P1.transform.position = transposition;

                            totalNum = DiceControl.P4_totalNum;
                            DiceControl.P4_totalNum = DiceControl.P1_totalNum;
                            DiceControl.P1_totalNum = totalNum;
                            break;

                        case 2:
                            transposition = P4.transform.position;
                            P4.transform.position = P2.transform.position;
                            P2.transform.position = transposition;

                            totalNum = DiceControl.P4_totalNum;
                            DiceControl.P4_totalNum = DiceControl.P2_totalNum;
                            DiceControl.P2_totalNum = totalNum;
                            break;

                        case 3:
                            transposition = P4.transform.position;
                            P4.transform.position = P3.transform.position;
                            P3.transform.position = transposition;

                            totalNum = DiceControl.P4_totalNum;
                            DiceControl.P4_totalNum = DiceControl.P3_totalNum;
                            DiceControl.P3_totalNum = totalNum;
                            break;
                    }
                    break;
            }
            BagUIControl.isTransposition = false;
            Invoke("FalseByAnimator", 1f);
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
    }

    void Initial()
    {
        P1Props[0] = 1;
        P1Props[1] = 1;
        P1Props[2] = 5;
        P1Props[3] = 1;
        P1Props[4] = 1;
        P1Props[5] = 1;
        P1Props[6] = 1;
        P2Props[0] = 0;
        P2Props[1] = 0;
        P2Props[2] = 5;
        P2Props[3] = 0;
        P2Props[4] = 0;
        P2Props[5] = 0;
        P2Props[6] = 0;
        P3Props[0] = 0;
        P3Props[1] = 0;
        P3Props[2] = 5;
        P3Props[3] = 0;
        P3Props[4] = 0;
        P3Props[5] = 0;
        P3Props[6] = 0;
        P4Props[0] = 0;
        P4Props[1] = 0;
        P4Props[2] = 5;
        P4Props[3] = 0;
        P4Props[4] = 0;
        P4Props[5] = 0;
        P4Props[6] = 0;
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
    void FindPlayer()
    {
        P1 = GameObject.FindGameObjectWithTag("P1");
        P2 = GameObject.FindGameObjectWithTag("P2");
        P3 = GameObject.FindGameObjectWithTag("P3");
        P4 = GameObject.FindGameObjectWithTag("P4");
    }
    void FalseByAnimator()
    {
        AnimatorControl.isP1Win = false;
        AnimatorControl.isP2Win = false;
        AnimatorControl.isP3Win = false;
        AnimatorControl.isP4Win = false;

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
