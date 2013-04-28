using UnityEngine;
using System.Collections;

public class HoverPressActivate : MonoBehaviour {
	bool mouseOver = false;
	
	void OnMouseEnter() {
		mouseOver = true;
	}
	
	void OnMouseExit() {
		mouseOver = false;
	}
	
	void Update() {
		if(mouseOver && Input.GetMouseButtonDown(0)) {
			gameObject.SendMessage("OnActivate", SendMessageOptions.DontRequireReceiver);
		}
	}
	
}
