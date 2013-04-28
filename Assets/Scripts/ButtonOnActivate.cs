using UnityEngine;
using System.Collections;

public class ButtonOnActivate : MonoBehaviour {
	public GameObject controller;
	public int number;
		
	public float pressDistance = -.01f;
	public MonoBehaviour[] disableOnOpen;
	public AudioClip pressSound;
	
	Vector3 initialPosition;
	
	void OnActivate() {
		if(!enabled) { return; }
		
		controller.SendMessage("OnButtonPress", number, SendMessageOptions.DontRequireReceiver);
		
		Press();
	}
	
	void Start() {
		initialPosition = transform.localPosition;
	}
		
	void Press() {
		if(!enabled) { return; }
		
		iTween.MoveTo(gameObject, iTween.Hash("y", initialPosition.y + pressDistance, "OnComplete", "UnPress", "islocal", true));
		AudioSource.PlayClipAtPoint(pressSound, transform.position);
		foreach(MonoBehaviour comp in disableOnOpen) {
			comp.enabled = false;
		}
	}
	
	void UnPress() {
		if(!enabled) { return; }
		
		iTween.MoveTo(gameObject, iTween.Hash("y", initialPosition.y, "islocal", true));
	}
	
}
