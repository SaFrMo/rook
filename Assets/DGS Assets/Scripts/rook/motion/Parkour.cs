using UnityEngine;
using System.Collections;

[RequireComponent(typeof(CharacterController))]
public class Parkour : MonoBehaviour {

	string parkourTag = "Parkour";

	bool hasJumped = false;
	bool parkourTouch;
	

	void OnControllerColliderHit(ControllerColliderHit hit) {
		if (hit.collider.gameObject.CompareTag (parkourTag)) {
			parkourTouch = true;
		}
	}

	void WallRun() {
		// player must be jumping and moving both forward and left/right, as well as
		// touching a parkour-able wall
		if (Input.GetButtonDown ("Jump") &&
		    Input.GetAxisRaw ("Vertical") > 0 && 
		    Input.GetAxisRaw ("Horizontal") != 0) {
			if (parkourTouch) {
				print ("WALLRUN");
			}
		}
	}

	void Update () {
		WallRun();
	}
}
