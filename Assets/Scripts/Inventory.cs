using UnityEngine;
using System.Collections;

public class Inventory : MonoBehaviour {
	ArrayList inventory = new ArrayList();
	
	public void AddItem(string item) {
		if(!inventory.Contains(item)) {
			inventory.Add(item);
		}
	}
	
	public void RemoveItem(string item) {
		if(inventory.Contains(item)) {
			inventory.Remove(item);
		}
	}
	
	public bool HasItem(string item) {
		return inventory.Contains(item);
	}
}
