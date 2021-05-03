using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonListButton : MonoBehaviour
{
    [SerializeField]
    private Text myText;
    [SerializeField]
    private buttonListControl buttonControl;
    [SerializeField]
    private buttonListControl textcontrol;

    private string myTextString;
    
    public void SetText(string textString)
    {
        myTextString = textString;
        myText.text = textString;
    }
}
