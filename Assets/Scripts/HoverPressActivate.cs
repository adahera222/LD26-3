using UnityEngine;
using System.Collections;

public class HoverPressActivate : MonoBehaviour {
	bool mouseOver = false;
	
	void OnMouseEnter() {
		Debug.Log("mouse enter");
		mouseOver = true;
	}
	
	void OnMouseExit() {
		mouseOver = false;
	}
	
	void Update() {
		//if(mouseOver && (Input.GetMouseButtonDown(0) || Input.GetButtonDown ("Fire1"))) {
		if(mouseOver && Input.GetButtonDown ("Fire1")) {
			gameObject.SendMessage("OnActivate", SendMessageOptions.DontRequireReceiver);
		}
	}
	
	void OnClick() {
		gameObject.SendMessage("OnActivate", SendMessageOptions.DontRequireReceiver);
	}
	
}
