using UnityEngine;
using System.Collections;

public class LoadNextLevelOnActivate : MonoBehaviour {
	void OnActivate() {
		Debug.Log("load next level");
		Application.LoadLevel(Application.loadedLevel + 1);
	}
}
