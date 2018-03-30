using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionRightHand : MonoBehaviour {

	public Vector3 positionright;
	// Update is called once per frame
	void Update () {
		
		positionright = transform.position;
		Debug.Log (positionright);
	}
}
