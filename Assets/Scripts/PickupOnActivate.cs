using UnityEngine;
using System.Collections;

public class PickupOnActivate : MonoBehaviour {
	Inventory inventory;
	public AudioClip pickupSound;
	
	void OnActivate() {
		inventory.AddItem(name);
		AudioSource.PlayClipAtPoint(pickupSound, transform.position);
		gameObject.SendMessage("OnMouseExit", SendMessageOptions.DontRequireReceiver);
		gameObject.SetActive(false);
	}
	
	// Use this for initialization
	void Start () {
		inventory = GameObject.Find("Player").GetComponent<Inventory>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
