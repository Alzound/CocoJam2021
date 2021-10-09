using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangePhoto : MonoBehaviour
{

    //public RawImage myColor;
    public List<GameObject> stages = new List<GameObject>();

    int currentIndex = 0;
    int newIndex = 0;
    int index = 0;
    void Start()
    {

        stages[currentIndex].SetActive(true);

    }

    public void rightButton()
    {
        stages[currentIndex].SetActive(false);
        newIndex = index + 1;
        if (newIndex > 2) newIndex = 0;
        index = newIndex;
        CurrentStage(newIndex);       
    }

    public void leftButton()
    {
        stages[currentIndex].SetActive(false);
        newIndex = index - 1;
        if (newIndex < 0) newIndex = 2;
        index = newIndex;
        CurrentStage(newIndex);
    }

    void CurrentStage(int scene)
    {
        switch(scene)
        {
            case 0:
                currentIndex = scene;
                stages[currentIndex].SetActive(true);
                break;
            case 1:
                currentIndex = scene;
                stages[currentIndex].SetActive(true);
                break;
            case 2:
                currentIndex = scene;
                stages[currentIndex].SetActive(true);
                break;
        }
    }

}
