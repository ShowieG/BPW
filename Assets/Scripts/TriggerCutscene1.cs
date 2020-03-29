using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class TriggerCutscene1 : MonoBehaviour {

    public GameObject Player;
    public PlayableDirector Timeline;
    public GameObject cutsceneCam;

	void OnTriggerEnter(Collider other)
    {
        this.gameObject.GetComponent<BoxCollider>().enabled = false;
        Player.SetActive(false);
        Timeline.Play();
        StartCoroutine(FinishCut());
    }

    IEnumerator FinishCut()
    {
        yield return new WaitForSeconds(5);
        Player.SetActive(true);
        cutsceneCam.SetActive(false);
    }
}
