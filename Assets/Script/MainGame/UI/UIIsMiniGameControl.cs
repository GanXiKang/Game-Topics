using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIIsMiniGameControl : MonoBehaviour
{
    void Update()
    {
        if (MiniGameColliderControl.isMiniGame)
        {
            this.gameObject.SetActive(false);
        }
        else
        {
            this.gameObject.SetActive(true);
        }
    }
}
