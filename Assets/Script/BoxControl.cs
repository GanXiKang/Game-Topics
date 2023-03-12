using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxControl : MonoBehaviour
{
    public Transform unopen;
    public Transform open;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player" && Dice.totalNum == 2)
        {
            print("��ϲ�@��10؈؈�ţ�");
            Vector3.MoveTowards(unopen.transform.position, open.transform.position, 0.3f);
            this.gameObject.SetActive(false);
            Destroy(this.gameObject);
        }
    }
}
