using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DiceUIControl : MonoBehaviour
{
    AudioSource BGM;

    public AudioClip dice;
    public GameObject interactiveUI;

    public static bool isDiceUI = true, isDiceScene = false;

    void Start()
    {
        BGM = GetComponent<AudioSource>();
    }
    void Update()
    {
        if (isDiceUI)
        {
            interactiveUI.SetActive(true);
        }
        else
        {
            interactiveUI.SetActive(false);
        }
    }
    public void Button_Dice()
    {
        StartCoroutine(GoDiceScene());
    }
    IEnumerator GoDiceScene()
    {
        BGM.PlayOneShot(dice);
        isDiceUI = false;
        yield return new WaitForSeconds(0.2f);
        SceneManager.LoadScene(9);
        isDiceScene = true;
    }
}
