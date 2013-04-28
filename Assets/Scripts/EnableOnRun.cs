using UnityEngine;
using System.Collections;

public class EnableOnRun : MonoBehaviour {
	public GameObject[] objects;
	
	// Use this for initialization
	void Start () {
		foreach(GameObject obj in objects) {
			obj.SetActive(true);
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
