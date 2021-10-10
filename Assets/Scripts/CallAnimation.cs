using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CallAnimation : MonoBehaviour
{
    public GameObject animController;

    public GameObject continueButton;
    void Start()
    {
        animController.GetComponent<Animator>().Play("Intro_1");

        continueButton.SetActive(true);
    }

    public void ChoosePath()
    {

    }
}
