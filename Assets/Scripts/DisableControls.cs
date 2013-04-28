using UnityEngine;
using System.Collections;

public class DisableControls : MonoBehaviour {
	public MonoBehaviour[] scripts;
	public GameObject[] chainObjects;
	
	public void Disable() {
		foreach(MonoBehaviour script in scripts) {
			script.enabled = false;
		}
		foreach(GameObject obj in chainObjects) {
			DisableControls dc = obj.GetComponent<DisableControls>();
			if(dc != null) {
				dc.Disable();
			}
		}
	}
}
