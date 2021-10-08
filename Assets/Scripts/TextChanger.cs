using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextChanger : MonoBehaviour
{
    [SerializeField]
    public List<string> textRight = new List<string>();
    [SerializeField]
    public List<string> textLeft = new List<string>();
    [SerializeField]
    public List<string> textMain = new List<string>();

    
    public TextMeshProUGUI mainText;
    public TextMeshProUGUI introduction; 

    int indexL = 0, indexR = 0, indexM = 0; 

    private void Start()
    {
        indexL = 0;
        indexR = 0;
        indexM = 0;
    }


    public void MainText()
    {
        
        mainText.text = textMain[indexM];
        indexM++; 
    }

    public void RightText()
    {
        mainText.text = textRight[indexR];
        indexR++;
    }

    public void LeftText()
    {
        mainText.text = textLeft[indexL];
        indexL++;
    }
}
