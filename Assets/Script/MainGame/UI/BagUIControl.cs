using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BagUIControl : MonoBehaviour
{
    AudioSource BGM;

    public GameObject bagUI;
    public GameObject interactiveUI;
    public Button[] use = new Button[7];

    public static bool isRenewDice, isDoubleDice, isCustomDice, isBomb, isSnatch, isTransposition, isThief;

    int whyUseProps;
    bool useProps;

    void Start()
    {
        BGM = GetComponent<AudioSource>();
    }
    void Update()
    {
        switch (ChangeCameraControl.changeCameraNum)
        {
            case 1:
                if (PropsControl.P1Props[0] > 0)
                {
                    use[0].interactable = true;
                }
                else
                {
                    use[0].interactable = false;
                }
                if (PropsControl.P1Props[1] > 0)
                {
                    use[1].interactable = true;
                }
                else
                {
                    use[1].interactable = false;
                }
                if (PropsControl.P1Props[2] > 0)
                {
                    use[2].interactable = true;
                }
                else
                {
                    use[2].interactable = false;
                }
                if (PropsControl.P1Props[3] > 0)
                {
                    use[3].interactable = true;
                }
                else
                {
                    use[3].interactable = false;
                }
                if (PropsControl.P1Props[4] > 0)
                {
                    use[4].interactable = true;
                }
                else
                {
                    use[4].interactable = false;
                }
                if (PropsControl.P1Props[5] > 0)
                {
                    use[5].interactable = true;
                }
                else
                {
                    use[5].interactable = false;
                }
                if (PropsControl.P1Props[6] > 0)
                {
                    use[6].interactable = true;
                }
                else
                {
                    use[6].interactable = false;
                }
                break;

            case 2:
                if (PropsControl.P2Props[0] > 0)
                {
                    use[0].interactable = true;
                }
                else
                {
                    use[0].interactable = false;
                }
                if (PropsControl.P2Props[1] > 0)
                {
                    use[1].interactable = true;
                }
                else
                {
                    use[1].interactable = false;
                }
                if (PropsControl.P2Props[2] > 0)
                {
                    use[2].interactable = true;
                }
                else
                {
                    use[2].interactable = false;
                }
                if (PropsControl.P2Props[3] > 0)
                {
                    use[3].interactable = true;
                }
                else
                {
                    use[3].interactable = false;
                }
                if (PropsControl.P2Props[4] > 0)
                {
                    use[4].interactable = true;
                }
                else
                {
                    use[4].interactable = false;
                }
                if (PropsControl.P2Props[5] > 0)
                {
                    use[5].interactable = true;
                }
                else
                {
                    use[5].interactable = false;
                }
                if (PropsControl.P2Props[6] > 0)
                {
                    use[6].interactable = true;
                }
                else
                {
                    use[6].interactable = false;
                }
                break;

            case 3:
                if (PropsControl.P3Props[0] > 0)
                {
                    use[0].interactable = true;
                }
                else
                {
                    use[0].interactable = false;
                }
                if (PropsControl.P3Props[1] > 0)
                {
                    use[1].interactable = true;
                }
                else
                {
                    use[1].interactable = false;
                }
                if (PropsControl.P3Props[2] > 0)
                {
                    use[2].interactable = true;
                }
                else
                {
                    use[2].interactable = false;
                }
                if (PropsControl.P3Props[3] > 0)
                {
                    use[3].interactable = true;
                }
                else
                {
                    use[3].interactable = false;
                }
                if (PropsControl.P3Props[4] > 0)
                {
                    use[4].interactable = true;
                }
                else
                {
                    use[4].interactable = false;
                }
                if (PropsControl.P3Props[5] > 0)
                {
                    use[5].interactable = true;
                }
                else
                {
                    use[5].interactable = false;
                }
                if (PropsControl.P3Props[6] > 0)
                {
                    use[6].interactable = true;
                }
                else
                {
                    use[6].interactable = false;
                }
                break;

            case 4:
                if (PropsControl.P4Props[0] > 0)
                {
                    use[0].interactable = true;
                }
                else
                {
                    use[0].interactable = false;
                }
                if (PropsControl.P4Props[1] > 0)
                {
                    use[1].interactable = true;
                }
                else
                {
                    use[1].interactable = false;
                }
                if (PropsControl.P4Props[2] > 0)
                {
                    use[2].interactable = true;
                }
                else
                {
                    use[2].interactable = false;
                }
                if (PropsControl.P4Props[3] > 0)
                {
                    use[3].interactable = true;
                }
                else
                {
                    use[3].interactable = false;
                }
                if (PropsControl.P4Props[4] > 0)
                {
                    use[4].interactable = true;
                }
                else
                {
                    use[4].interactable = false;
                }
                if (PropsControl.P4Props[5] > 0)
                {
                    use[5].interactable = true;
                }
                else
                {
                    use[5].interactable = false;
                }
                if (PropsControl.P4Props[6] > 0)
                {
                    use[6].interactable = true;
                }
                else
                {
                    use[6].interactable = false;
                }
                break;
        }
        if (useProps)
        {
            switch (ChangeCameraControl.changeCameraNum)
            {
                case 1:
                    switch (whyUseProps)
                    {
                        case 1:
                            PropsControl.P1Props[0] -= 1;
                            break;

                        case 2:
                            PropsControl.P1Props[1] -= 1;
                            break;

                        case 3:
                            PropsControl.P1Props[2] -= 1;
                            break;

                        case 4:
                            PropsControl.P1Props[3] -= 1;
                            break;

                        case 5:
                            PropsControl.P1Props[4] -= 1;
                            break;

                        case 6:
                            PropsControl.P1Props[5] -= 1;
                            break;

                        case 7:
                            PropsControl.P1Props[6] -= 1;
                            break;
                    }
                    break;

                case 2:
                    switch (whyUseProps)
                    {
                        case 1:
                            PropsControl.P2Props[0] -= 1;
                            break;

                        case 2:
                            PropsControl.P2Props[1] -= 1;
                            break;

                        case 3:
                            PropsControl.P2Props[2] -= 1;
                            break;

                        case 4:
                            PropsControl.P2Props[3] -= 1;
                            break;

                        case 5:
                            PropsControl.P2Props[4] -= 1;
                            break;

                        case 6:
                            PropsControl.P2Props[5] -= 1;
                            break;

                        case 7:
                            PropsControl.P2Props[6] -= 1;
                            break;
                    }
                    break;

                case 3:
                    switch (whyUseProps)
                    {
                        case 1:
                            PropsControl.P3Props[0] -= 1;
                            break;

                        case 2:
                            PropsControl.P3Props[1] -= 1;
                            break;

                        case 3:
                            PropsControl.P3Props[2] -= 1;
                            break;

                        case 4:
                            PropsControl.P3Props[3] -= 1;
                            break;

                        case 5:
                            PropsControl.P3Props[4] -= 1;
                            break;

                        case 6:
                            PropsControl.P3Props[5] -= 1;
                            break;

                        case 7:
                            PropsControl.P3Props[6] -= 1;
                            break;
                    }
                    break;

                case 4:
                    switch (whyUseProps)
                    {
                        case 1:
                            PropsControl.P4Props[0] -= 1;
                            break;

                        case 2:
                            PropsControl.P4Props[1] -= 1;
                            break;

                        case 3:
                            PropsControl.P4Props[2] -= 1;
                            break;

                        case 4:
                            PropsControl.P4Props[3] -= 1;
                            break;

                        case 5:
                            PropsControl.P4Props[4] -= 1;
                            break;

                        case 6:
                            PropsControl.P4Props[5] -= 1;
                            break;

                        case 7:
                            PropsControl.P4Props[6] -= 1;
                            break;
                    }
                    break;
            }
            useProps = false;
        }
    }
    public void Button_Bag()
    {
        bagUI.SetActive(true);
        interactiveUI.SetActive(false);
    }
    public void Button_Close()
    {
        bagUI.SetActive(false);
        interactiveUI.SetActive(true);
    }
    public void Button_Use(int why)
    {
        whyUseProps = why;
        useProps = true;
        switch (whyUseProps)
        {
            case 1:
                isRenewDice = true;
                print("isRenewDice");
                break;

            case 2:
                isDoubleDice = true;
                print("isDoubleDice");
                break;

            case 3:
                isCustomDice = true;
                print("isCustomDice");
                break;

            case 4:
                isBomb = true;
                print("isBomb");
                break;

            case 5:
                isSnatch = true;
                print("isSnatch");
                break;

            case 6:
                isTransposition = true;
                print("isTransposition");
                break;

            case 7:
                isThief = true;
                print("isThief");
                break;
        }
    }
}
