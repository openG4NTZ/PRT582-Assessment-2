﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Manager : MonoBehaviour
{

    public void open_arscene()
    {
        SceneManager.LoadScene(1);
    }

}