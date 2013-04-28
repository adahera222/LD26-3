using UnityEngine;
using System.Collections;

public class OpenExitDoorOnActivate : MonoBehaviour {
	public GameObject CompleteUI;

	Inventory inventory;
	
	DisableControls disableControls;
	
	void OnActivate() {
		if(inventory.HasItem("Key")) {
			gameObject.SendMessage("OnOpen", SendMessageOptions.DontRequireReceiver);
			disableControls.Disable();
			CompleteUI.SetActive(true);
		}
	}
	
	// Use this for initialization
	void Start () {
		inventory = GameObject.Find("Player").GetComponent<Inventory>();
		disableControls = GameObject.Find("Player").GetComponent<DisableControls>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
