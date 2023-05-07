using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest1AnimationControl : MonoBehaviour
{
    Animation ani;
    public GameObject effects;
    public AudioSource BGM;
    public AudioClip open;

    void Start()
    {
        ani = GetComponent<Animation>();
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
        ani.Play("Open");
        BGM.PlayOneShot(open);
        Instantiate(effects, transform.position, transform.rotation);
        ChestColliderControl.isOpen1 = false;
        yield return new WaitForSeconds(3f);
        this.gameObject.SetActive(false);
    }
}
