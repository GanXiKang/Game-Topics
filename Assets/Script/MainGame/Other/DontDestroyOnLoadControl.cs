using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroyOnLoadControl : MonoBehaviour
{
    public static bool newGame;
    static DontDestroyOnLoadControl instance;
    void Start()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else if (this != instance)
        {
            Destroy(gameObject);
        }
    }
    void FixedUpdate()
    {
        if (newGame)
        {
            //Destroy(this.gameObject);
            instance = null;
            newGame = false;
        }
    }
}
