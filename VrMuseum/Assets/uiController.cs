using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class uiController : MonoBehaviour {
	public GameObject[] uiElements;
	public int count;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void nextSlide() {
	
		if (count < 4) {
			GameObject currentObj = uiElements[count];
			currentObj.SetActive(false);
			count = count + 1;
			GameObject nextObj = uiElements[count];
			nextObj.SetActive(true);
		}
	}

	public void prevSlide() {
		Debug.Log("Prev");
		if (count > 0) {
			GameObject currentObj = uiElements[count];
			currentObj.SetActive(false);
			count = count - 1;
			GameObject prev = uiElements[count];
			prev.SetActive(true);

		}
	}
}
