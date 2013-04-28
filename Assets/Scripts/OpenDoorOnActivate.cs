using UnityEngine;
using System.Collections;

[RequireComponent(typeof (OpenDoor))]
public class OpenDoorOnActivate : MonoBehaviour {

	void OnActivate() {
		gameObject.SendMessage("OnOpen", SendMessageOptions.DontRequireReceiver);
	}
}
