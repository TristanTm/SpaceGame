using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knop : MonoBehaviour
{
    public GameObject EchteKnop;
    public GameObject NepKnop;
    public GameObject VEchteKnop;
    public GameObject VNepKnop;
    public GameObject knop4;
    public GameObject knop44;


    public void a()
    {
        EchteKnop.SetActive(false);
        NepKnop.SetActive(true);
        VEchteKnop.SetActive(true);
        VNepKnop.SetActive(false);

    }



    public void button4()
    {
        knop4.SetActive(false);
        knop44.SetActive(true);
    }
}




