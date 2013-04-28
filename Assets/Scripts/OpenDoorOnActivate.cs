using UnityEngine;
using System.Collections;

public class OpenDoorOnActivate : MonoBehaviour {

	void OnActivate() {
		if(!enabled) { return; }
		
		gameObject.SendMessage("OnOpen", SendMessageOptions.DontRequireReceiver);
	}
}
