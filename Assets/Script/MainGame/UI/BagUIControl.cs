using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BagUIControl : MonoBehaviour
{
    AudioSource BGM;

    public AudioClip insProps, bag, button;
    public GameObject bagUI;
    public Button[] use = new Button[7];

    public static bool isRenewDice, isDoubleDice, isCustomDice, putBomb, isSnatch, isTransposition, isThief;

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
        DiceUIControl.isDiceUI = false;
        BGM.PlayOneShot(bag);
    }
    public void Button_Close()
    {
        bagUI.SetActive(false);
        DiceUIControl.isDiceUI = true;
        BGM.PlayOneShot(button);
    }
    public void Button_Use(int why)
    {
        whyUseProps = why;
        BGM.PlayOneShot(insProps);
        StartCoroutine(UseProps());
    }

    IEnumerator UseProps()
    {
        useProps = true;
        yield return new WaitForSeconds(0.2f);
        bagUI.SetActive(false);
        switch (whyUseProps)
        {
            case 1:
                isRenewDice = true;
                InsPropsControl.isInsAgainDice = true;
                GoDiceScene();
                break;

            case 2:
                isDoubleDice = true;
                InsPropsControl.isInsDoubleDice = true;
                GoDiceScene();
                break;

            case 3:
                isCustomDice = true;
                InsPropsControl.isInsCustomDice = true;
                GoDiceScene();
                break;

            case 4:
                putBomb = true;
                switch (ChangeCameraControl.changeCameraNum)
                {
                    case 1:
                        InsBombControl.isP1InsBomb = true;
                        break;

                    case 2:
                        InsBombControl.isP2InsBomb = true;
                        break;

                    case 3:
                        InsBombControl.isP3InsBomb = true;
                        break;

                    case 4:
                        InsBombControl.isP4InsBomb = true;
                        break;
                }
                CameraMoveControl.isChangeCameraPoint = true;
                yield return new WaitForSeconds(2f);
                GoDiceScene(); 
                CameraMoveControl.isChangeCameraPoint = false;
                break;

            case 5:
                isSnatch = true;
                InsPropsControl.isInsSnatch = true;
                CameraMoveControl.isChangeCameraPoint = true;
                yield return new WaitForSeconds(2f);
                ChangeCamera();
                CameraMoveControl.isChangeCameraPoint = false;
                break;

            case 6:
                isTransposition = true;
                InsPropsControl.isInsTrans = true;
                CameraMoveControl.isChangeCameraPoint = true;
                yield return new WaitForSeconds(2f);
                CameraMoveControl.isChangeCameraPoint = false;
                break;

            case 7:
                isThief = true;
                InsPropsControl.isInsThief = true;
                CameraMoveControl.isChangeCameraPoint = true;
                yield return new WaitForSeconds(2f);
                ChangeCamera();
                CameraMoveControl.isChangeCameraPoint = false;
                break;
        }
    }

    void GoDiceScene()
    {
        SceneManager.LoadScene(9);
        DiceUIControl.isDiceScene = true;
    }
    void ChangeCamera()
    {
        DiceUIControl.isDiceUI = true;
        ChangeCameraControl.changeCameraNum++;
    }
}
