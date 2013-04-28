using UnityEngine;
using System.Collections;

public class WallSafeLogic : MonoBehaviour {
	public GameObject[] buttons;
	public GameObject door;
	
	public Color[] colors = new Color[4] {
		new Color(1, 0, 0, 1),
		new Color(0, 1, 0, 1),
		new Color(0, 0, 1, 1),
		new Color(1, 1, 0, 1)
	};
	
	public GameObject paper;
	
	ArrayList combination = new ArrayList();
	int combinationIndex = 0;
	
	void Start() {
		ProceduralMaterial paperMaterial = paper.renderer.sharedMaterial as ProceduralMaterial;
		
		ArrayList buttonNumbers = new ArrayList();
		
		//combination = new int[4];
		
		for(int index = 0; index < buttons.Length; index++) {
			GameObject button = buttons[index];
			ButtonOnActivate buttonScript = button.GetComponent<ButtonOnActivate>();
			buttonScript.controller = gameObject;
			buttonScript.number = index;
			buttonNumbers.Add (index);
			button.renderer.material.color = colors[index];
		}
		
		combination.Clear();
		for(int index = 0; index < 4; index++) {
			int removeItem = Random.Range(0, buttonNumbers.Count);
			combination.Add ((int)buttonNumbers[removeItem]);
			buttonNumbers.RemoveAt(removeItem);
		}

		for(int index = 0; index < combination.Count; index++) {
			int comboIndex = (int)combination[index];
			switch(index) {
				case 0:
					paperMaterial.SetProceduralColor("color1", colors[comboIndex]);
					break;
				case 1:
					paperMaterial.SetProceduralColor("color2", colors[comboIndex]);
					break;
				case 2:
					paperMaterial.SetProceduralColor("color3", colors[comboIndex]);
					break;
				case 3:
					paperMaterial.SetProceduralColor("color4", colors[comboIndex]);
					break;
			}
		}
		
		paperMaterial.RebuildTexturesImmediately();
	}
	
	void OnButtonPress(int number) {
		if(number < combination.Count) {
			if(number == (int)combination[combinationIndex]) {
				combinationIndex++;
			} else {
				combinationIndex = 0;
			}
		}
		
		if(combinationIndex >= combination.Count) {
			door.SendMessage("OnOpen", SendMessageOptions.DontRequireReceiver);
			combinationIndex = 0;
		}
	}
}
