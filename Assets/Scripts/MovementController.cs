using UnityEngine;
using System.Collections;

public class MovementController : MonoBehaviour {
	public Camera cardboardCamera;
	private Vector3 currentPosition;
	private float updatedPos;
	public GameObject playerController;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

//		if (cardboardCamera.transform.eulerAngles.y > 0) {
//			currentPosition = playerController.transform.position;
//			updatedPos = currentPosition.x + 0.2f;
//			playerController.transform.position = new Vector3( updatedPos , currentPosition.y, currentPosition.z);
//			Debug.Log ("updating pos " + updatedPos);
//		}
//		if (cardboardCamera.transform.eulerAngles.y < 0) {
//			currentPosition = playerController.transform.position;
//			updatedPos = currentPosition.x - 0.2f;
//			playerController.transform.position = new Vector3( updatedPos , currentPosition.y, currentPosition.z);
//			Debug.Log ("updating pos " + updatedPos);
//		}
//		if (cardboardCamera.transform.eulerAngles.x > 0) {
//			currentPosition = playerController.transform.position;
//			updatedPos = currentPosition.x + 0.2f;
//			playerController.transform.position = new Vector3( updatedPos , currentPosition.y, currentPosition.z);
//			Debug.Log ("pos " + updatedPos);
//		}
//		if (cardboardCamera.transform.eulerAngles.x < 0) {
//			currentPosition = playerController.transform.position;
//			updatedPos = currentPosition.x - 0.2f;
//			playerController.transform.position = new Vector3( updatedPos , currentPosition.y, currentPosition.z);
//			Debug.Log ("pos " + updatedPos);
//		}
	}
}
