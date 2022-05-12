using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdContinueStart : MonoBehaviour
{
    public GameObject Lore;
    public GameObject SecondButton;
    public GameObject StartCanvas;
    public GameObject player;

    public void onClick()
    {
        if (Lore == true)
            Lore.SetActive(false);
            SecondButton.SetActive(true);
            StartCanvas.SetActive(false);
            player.SetActive(true);

    }
}
