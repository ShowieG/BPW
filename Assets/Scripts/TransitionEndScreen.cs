using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransitionEndScreen : MonoBehaviour {

    public GameObject TransitionScreen;

    public void OnTriggerEnter()
    {
        TransitionScreen.SetActive(true);
    }
}
