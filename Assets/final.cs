using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class final : MonoBehaviour
{


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void end()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit(); 
        }
    }

    public void endClick()
    {
        Application.Quit(); 
    }
}
