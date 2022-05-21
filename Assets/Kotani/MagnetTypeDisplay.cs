using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MagnetTypeDisplay : MonoBehaviour
{
    [SerializeField]
    private MagnetSystem magnetSystem;
    [SerializeField]
    private Text text;
     [SerializeField]
    private GameObject Sq;
    private bool mag;

    // Update is called once per frame
    void Start()
    {
        MagTypeDisp();
    }
    public void MagTypeDisp()
    {
        if(magnetSystem.GetMagType()==true)
        {
            magnetSystem.SetMagType(false);
            text.text ="N";
            Sq.GetComponent<Image>().color = Color.red;
        }
        else
        {
            magnetSystem.SetMagType(true);
            text.text ="S";
            Sq.GetComponent<Image>().color = Color.blue;
        }
    }
}
