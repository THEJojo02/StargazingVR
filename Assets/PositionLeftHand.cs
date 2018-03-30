using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionLeftHand : MonoBehaviour {

	public Vector3 positionleft;
	
	// Update is called once per frame
	void Update () {
		
		positionleft = transform.position;
		Debug.Log (positionleft);
	}
}
