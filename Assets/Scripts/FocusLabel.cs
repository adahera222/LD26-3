using UnityEngine;
using System.Collections;

public class FocusLabel : MonoBehaviour {
	ArrayList labels = new ArrayList();
	UILabel focusLabel = null;
	
	public void AddLabel(string label) {
		if(!labels.Contains(label)) {
			labels.Add(label);
		}
		
		updateLabel();
	}
	
	public void RemoveLabel(string label) {
		if(labels.Contains(label)) {
			labels.Remove(label);
		}
		
		updateLabel();
	}
	
	public void updateLabel() {
		if(focusLabel != null) {
			if(labels.Count > 0) {
				focusLabel.text = (string)labels[labels.Count - 1];
			} else {
				focusLabel.text = "";
			}
		}
	}
	
	// Use this for initialization
	void Start () {
		focusLabel = GameObject.Find("FocusLabel").GetComponent<UILabel>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
