using System;
using System.Collections.Generic;
using UnityEngine;

public class DialogueManager : MonoBehaviour
{

    private Queue<string> sentences;


    void start()
    {
        sentences = new Queue<string>();

    }


}
