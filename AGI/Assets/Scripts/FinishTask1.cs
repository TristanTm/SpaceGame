using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishTask1 : MonoBehaviour
{
    public GameObject player;
    public GameObject Maincanvas;
    public GameObject rommel1;
    public GameObject rommel2;
    public GameObject rommel3;
    public GameObject task1;



    public void onclick()
    {
        if (rommel1.activeInHierarchy == false && rommel2.activeInHierarchy == false && rommel3.activeInHierarchy == false)
        {
                    task1.SetActive(false);
                    player.SetActive(true);
                    Maincanvas.SetActive(true);
                
            
        }
    }
}