using UnityEngine;
using System.Collections;

public class LoadNextLevelOnClick : MonoBehaviour {
	void OnMouseDown() {
		Application.LoadLevel(Application.loadedLevel + 1);
	}
}
