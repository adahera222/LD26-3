using UnityEngine;
using System.Collections;

public class OpenDoor : MonoBehaviour {
	public float closedAngle = 0f;
	public float openAngle = 160f;
	public MonoBehaviour[] disableOnOpen;
	public AudioClip openSound;
	
	float initialAngle;
	
	void Start() {
		initialAngle = transform.rotation.eulerAngles.y;
	}
		
	void OnOpen() {
		iTween.RotateTo(gameObject, iTween.Hash("y", initialAngle + openAngle));
		AudioSource.PlayClipAtPoint(openSound, transform.position);
		foreach(MonoBehaviour comp in disableOnOpen) {
			comp.enabled = false;
		}
	}
	
	void OnClose() {
		
	}
}
