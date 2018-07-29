using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceBorder : MonoBehaviour {

	public GameObject borderTemplate;
	public GameObject player;
	public GameObject wallElements;

	Vector3 lastPosition;

	// Use this for initialization
	void Start () {
		lastPosition = player.transform.position + 2.5f * (player.transform.rotation * borderTemplate.transform.localPosition);
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 currentPosition = player.transform.position + 2.5f * (player.transform.rotation * borderTemplate.transform.localPosition);
		Debug.Log ("currentPosition: " + currentPosition + " ; lastPosition: " + lastPosition);
		if ((currentPosition - lastPosition).magnitude >= 1) { // constraint for placing new wall element
			
			GameObject newWallElement = Instantiate(borderTemplate, (currentPosition + lastPosition) / 2, Quaternion.LookRotation((currentPosition - lastPosition)), wallElements.transform);
			//newWallElement.transform.Rotate (currentPosition - lastPosition);
			newWallElement.transform.localScale = Vector3.Scale(newWallElement.transform.localScale, new Vector3 (1, 1, (currentPosition - lastPosition).magnitude));
			lastPosition = currentPosition;
		}

	}
}
