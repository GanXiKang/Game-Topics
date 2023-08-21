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
}
