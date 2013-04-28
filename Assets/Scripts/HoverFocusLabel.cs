using UnityEngine;
using System.Collections;

public class HoverFocusLabel : MonoBehaviour {
	public string hoverText = "";
	
	FocusLabel focusLabel;
	
	void Start() {
		focusLabel = GameObject.Find("FocusLabel").GetComponent<FocusLabel>();
	}
	
	void OnMouseEnter() {
		if(!enabled) { return; }
		focusLabel.AddLabel(hoverText);
	}
	
	void OnMouseExit() {
		focusLabel.RemoveLabel(hoverText);
	}
}
