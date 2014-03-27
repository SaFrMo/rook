using UnityEngine;
using System.Collections;

public class CastleGuardMotion : MonoBehaviour {

	static string walkingAnimation = "walk_40";

	// ANIMATION STATES FOR CASTLE GUARD
	public bool IsMoving { get; private set; }
	// bool IsWalking;

	Vector3 lastPosition;

	void Animate() {
		if (IsMoving) {



			// if (isWalking) {
			if (!animation.IsPlaying (walkingAnimation)) {
				animation.Play (walkingAnimation);
			}
		}
	}

	void Update () {
		if (transform.position != lastPosition) {
			IsMoving = true;
		}
		lastPosition = transform.position;

		Animate ();
	}

}
