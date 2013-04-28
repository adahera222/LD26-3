using UnityEngine;
using System.Collections;

public class AddInventoryOnActivate : MonoBehaviour {
	Inventory inventory;
	
	// Use this for initialization
	void Start () {
		inventory = GameObject.Find("Player").GetComponent<Inventory>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
