using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Chest2AnimationControl : MonoBehaviour
{
    Animation ani;

    public GameObject effects;
    public Transform pointEff;
    public Text systemTest;
    public AudioSource BGM;
    public AudioClip open;

    public static bool openedBox2 = false;

    int a;
    void Start()
    {
        ani = GetComponent<Animation>();

        if (openedBox2)
        {
            Destroy(this.gameObject);
        }
    }
    void Update()
    {
        if (ChestColliderControl.isOpen2)
        {
            StartCoroutine(ChestActive());
        }
    }
    //void Award()
    //{
    //    a = Random.Range(1, 11);
    //    switch (a)
    //    {
    //        case 1:
    //        case 2:
    //        case 3:
    //        case 4:
    //            systemTest.text = "獲得10個貓貓幣！";
    //            systemTest.color = Color.yellow;
    //            SystemTestTextControl.isTimer = true;
    //            break;
    //        case 5:
    //        case 6:
    //            systemTest.text = "獲得20個貓貓幣！";
    //            systemTest.color = Color.yellow;
    //            SystemTestTextControl.isTimer = true;
    //            break;
    //        case 7:
    //        case 8:
    //            systemTest.text = "獲得30個貓貓幣！";
    //            systemTest.color = Color.yellow;
    //            SystemTestTextControl.isTimer = true;
    //            break;
    //        case 9:
    //            systemTest.text = "獲得一個道具！";
    //            systemTest.color = Color.yellow;
    //            SystemTestTextControl.isTimer = true;
    //            break;
    //        case 10:
    //            systemTest.text = "空！";
    //            systemTest.color = Color.black;
    //            SystemTestTextControl.isTimer = true;
    //            break;
    //    }
    //}
    IEnumerator ChestActive()
    {
        //Award();
        openedBox2 = true;
        ani.Play("Open");
        BGM.PlayOneShot(open);
        Instantiate(effects, pointEff.transform.position, pointEff.transform.rotation);
        ChestColliderControl.isOpen2 = false;
        yield return new WaitForSeconds(5f);
    }
}
