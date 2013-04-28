using UnityEngine;
using System.Collections;

public class OpenDrawer : MonoBehaviour {
	public float closedDistance = 0f;
	public float openDistance = 2f;
	public MonoBehaviour[] disableOnOpen;
	public AudioClip openSound;
	
	Vector3 initialPosition;
	
	void Start() {
		initialPosition = transform.position;
	}
		
	void OnOpen() {
		if(!enabled) { return; }
		
		iTween.MoveTo(gameObject, iTween.Hash("z", initialPosition.z + openDistance));
		AudioSource.PlayClipAtPoint(openSound, transform.position);
		foreach(MonoBehaviour comp in disableOnOpen) {
			comp.enabled = false;
		}
	}
	
	void OnClose() {
		
	}
}
