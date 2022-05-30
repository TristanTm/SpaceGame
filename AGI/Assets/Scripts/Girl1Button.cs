using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Girl1Button : MonoBehaviour
{
    public GameObject LoveCanvas;
    public GameObject GirlCanvas;
    public GameObject heart1;
    public GameObject heart2;
    public GameObject heart3;
    public GameObject heart4;
    public GameObject heart5;
    public GameObject ActiveHeart1;
    public GameObject ActiveHeart2;
    public GameObject ActiveHeart3;
    public GameObject ActiveHeart4;
    public GameObject ActiveHeart5;

    public void onclick()
    {
        GirlCanvas.SetActive(true);
        LoveCanvas.SetActive(false);
        if (ActiveHeart1.activeInHierarchy == false)
        {
            heart1.SetActive(false);
            heart2.SetActive(false);
            heart3.SetActive(false);
            heart4.SetActive(false);
            heart5.SetActive(false);
        }
        if (ActiveHeart2.activeInHierarchy == false)
        {
            heart2.SetActive(false);
            heart3.SetActive(false);
            heart4.SetActive(false);
            heart5.SetActive(false);
        }
        if (ActiveHeart3.activeInHierarchy == false)
        {
            heart3.SetActive(false);
            heart4.SetActive(false);
            heart5.SetActive(false);
        }
        if (ActiveHeart4.activeInHierarchy == false)
        {
            heart4.SetActive(false);
            heart5.SetActive(false);
        }
        if (ActiveHeart5.activeInHierarchy == false)
        {
            heart5.SetActive(false);
        }
    }
}
