﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndScreen : MonoBehaviour {

	public void LoadEndScreen()
    {
        SceneManager.LoadScene("EndScreen");
    }
}
