using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class TriggerBoat : MonoBehaviour {

    public GameObject Player;
    public PlayableDirector Timeline;

    void OnTriggerEnter(Collider other)
    {
        this.gameObject.GetComponent<BoxCollider>().enabled = false;
        Timeline.Play();
    }
 
}
