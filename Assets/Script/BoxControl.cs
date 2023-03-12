using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxControl : MonoBehaviour
{
    public Transform unopen;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player" && Dice.totalNum == 2)
        {
            print("¹§Ï²«@µÃ10ØˆØˆŽÅ£¡");
            unopen.transform.Translate(0, 5, 0);
            Destroy(this.gameObject, 2f);
        }
    }
}
