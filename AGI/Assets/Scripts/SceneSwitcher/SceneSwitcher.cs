using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : Interactable
{


    public override void interact()
    {
        SceneManager.LoadScene(0);
    }


}
