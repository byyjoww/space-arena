﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitGame : MonoBehaviour {
    
    public void Quit ()    {
        Application.Quit();
        Debug.Log("Quit");
    }
}
