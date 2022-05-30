using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enter : MonoBehaviour
{
    public GameObject knop4;
    public GameObject knop3;
    public GameObject knop2;
    public GameObject knop1;
    public GameObject player;
    public GameObject Maincanvas;
    public GameObject Codepanel;
    public GameObject closeddoor;
    public GameObject opendoor;
    public GameObject TyfusDeur;

    public void onclick()
    {
        if (knop1.activeInHierarchy == false && knop2.activeInHierarchy == false && knop3.activeInHierarchy == false && knop4.activeInHierarchy == false)
        {
            Codepanel.SetActive(false);
            player.SetActive(true);
            Maincanvas.SetActive(true);

            opendoor.SetActive(true);
            closeddoor.SetActive(false);
            Destroy(TyfusDeur);
        }
    }
}
