using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest1AnimationControl : MonoBehaviour
{
    Animation ani;

    public GameObject effects;
    public Transform pointEff;
    public AudioSource BGM;
    public AudioClip open;

    public static bool openedBox1 = false;

    void Start()
    {
        ani = GetComponent<Animation>();

        if (openedBox1)
        {
            Destroy(this.gameObject);
        }
    }
    void Update()
    {
        if (ChestColliderControl.isOpen1)
        {
            StartCoroutine(ChestActive());
        }
    }
    IEnumerator ChestActive()
    {
        openedBox1 = true;
        ani.Play("Open");
        BGM.PlayOneShot(open);
        Instantiate(effects, pointEff.transform.position, pointEff.transform.rotation);
        ChestColliderControl.isOpen1 = false;
        yield return new WaitForSeconds(3f);
        this.gameObject.SetActive(false);
        Destroy(this.gameObject);
    }
}
