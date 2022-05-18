using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CodePanel : MonoBehaviour
{
    [SerializeField]
    Text codeText;
    string codeTextValue = "";
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if (codeTextValue == "1234")
        {
            Doors.isDoorOpened = true;
        }

        if (codeTextValue.Length >= 4)
            codeTextValue = "";
    }

    public void AddDigit(string digit)
    {
        codeTextValue += digit;
    }
}
