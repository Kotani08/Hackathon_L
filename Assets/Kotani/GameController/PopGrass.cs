using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopGrass : MonoBehaviour
{
    public GameObject a;
    // Update is called once per frame
    void Start()
    {
        a.gameObject.SetActive(false);
    }

    void OnTriggerExit2D(Collider2D collider)
    {
        if(collider.tag == "Player")
        {
        a.gameObject.SetActive(true);
        }
    }
}
