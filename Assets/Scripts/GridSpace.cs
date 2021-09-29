using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GridSpace : MonoBehaviour
{
    public Button button;
    public Text buttonText;
    public string playerside;
    public void SetSpace()
    {
        buttonText.text = playerside;
        button.interactable = false;
    }
}
