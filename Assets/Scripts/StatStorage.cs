using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatStorage : MonoBehaviour
{
    public int brvPoints, nrvPoints, lckPoints;

    public static StatStorage instance;

    private void Awake()
    {
        if (instance == null) { instance = this; }
        else
        {
            Destroy(gameObject);
            return;
        }
        DontDestroyOnLoad(gameObject);
    }
}
