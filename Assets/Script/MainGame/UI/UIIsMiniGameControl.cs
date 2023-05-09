using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIIsMiniGameControl : MonoBehaviour
{
    public GameObject UI_MainGame;
    
    void Update()
    {
        if (MiniGameColliderControl.isMiniGame)
        {
            UI_MainGame.SetActive(false);
        }
        else
        {
            UI_MainGame.SetActive(true);
        }
    }
}
