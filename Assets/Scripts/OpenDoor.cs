using UnityEngine;
using System.Collections;

public class OpenDoor : MonoBehaviour {
	public float closedAngle = 0f;
	public float openAngle = 160f;
	public MonoBehaviour[] disableOnOpen;
	public AudioClip openSound;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnOpen() {
		iTween.RotateTo(gameObject, iTween.Hash("y", openAngle));
		AudioSource.PlayClipAtPoint(openSound, transform.position);
		foreach(MonoBehaviour comp in disableOnOpen) {
			comp.enabled = false;
		}
	}
	
	void OnClose() {
		
	}
}
