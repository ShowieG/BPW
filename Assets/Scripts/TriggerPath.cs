using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class TriggerPath : MonoBehaviour
{

    public GameObject Player;
    public PlayableDirector Timeline;
    public GameObject OtherTrigger;

    void OnTriggerEnter(Collider other)
    {
        this.gameObject.GetComponent<BoxCollider>().enabled = false;
        OtherTrigger.GetComponent<BoxCollider>().enabled = false;
        Timeline.Play();
    }

}
