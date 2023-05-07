using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest2AnimationControl : MonoBehaviour
{
    Animation ani;

    public GameObject effects;
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
        if (ChestColliderControl.isOpen2)
        {
            StartCoroutine(ChestActive());
        }
    }
    IEnumerator ChestActive()
    {
        openedBox1 = true;
        ani.Play("Open");
        BGM.PlayOneShot(open);
        Instantiate(effects, transform.position, transform.rotation);
        ChestColliderControl.isOpen2 = false;
        yield return new WaitForSeconds(5f);
        this.gameObject.SetActive(false);
    }
}
