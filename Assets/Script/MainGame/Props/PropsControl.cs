using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PropsControl : MonoBehaviour
{
    public static int[] P1Props = new int[7];
    public static int[] P2Props = new int[7];
    public static int[] P3Props = new int[7];
    public static int[] P4Props = new int[7];

    public Text[] PropsQuantity = new Text[7];

    void Start()
    {
        Initial();
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
    }
    void Initial()
    {
        P1Props[0] = 0;
        P1Props[1] = 0;
        P1Props[2] = 0;
        P1Props[3] = 0;
        P1Props[4] = 0;
        P1Props[5] = 0;
        P1Props[6] = 0;
        P2Props[0] = 0;
        P2Props[1] = 0;
        P2Props[2] = 0;
        P2Props[3] = 0;
        P2Props[4] = 0;
        P2Props[5] = 0;
        P2Props[6] = 0;
        P3Props[0] = 0;
        P3Props[1] = 0;
        P3Props[2] = 0;
        P3Props[3] = 0;
        P3Props[4] = 0;
        P3Props[5] = 0;
        P3Props[6] = 0;
        P4Props[0] = 0;
        P4Props[1] = 0;
        P4Props[2] = 0;
        P4Props[3] = 0;
        P4Props[4] = 0;
        P4Props[5] = 0;
        P4Props[6] = 0;
    }
}
