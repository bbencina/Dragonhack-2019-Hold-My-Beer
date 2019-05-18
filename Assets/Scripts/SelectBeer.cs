﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectBeer : MonoBehaviour
{

	[SerializeField] List<GameObject> beerUnderUniversal;

	private int ind = 0;
	// Start is called before the first frame update


	private void Start () {
		foreach (GameObject beer in beerUnderUniversal) {
			beer.SetActive(false);
		}

		beerUnderUniversal[ind].SetActive(true);


	}

	private void Update () {
#if UNITY_EDITOR
		if (Input.GetKeyDown(KeyCode.LeftArrow)) {
			SwichToLeftBeer();
		}
		if (Input.GetKeyDown(KeyCode.RightArrow)) {
			SwichToRightBeer();
		}

#endif
	}

	public void SwichToLeftBeer () {
		beerUnderUniversal[ind].SetActive(false);
		ind--;
		if (ind < 0) {
			ind = beerUnderUniversal.Count - 1;
		}

		beerUnderUniversal[ind].SetActive(true);

	}

	public void SwichToRightBeer () {

		beerUnderUniversal[ind].SetActive(false);
		ind++;
		if (ind >= beerUnderUniversal.Count) {
			ind = 0;
		}

		beerUnderUniversal[ind].SetActive(true);
	}
}