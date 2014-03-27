using UnityEngine;
using System.Collections;

public class CombatRook : MonoBehaviour {

	string attackAnimation = "Attack";
	Animation a;
	bool doneAttacking = true;

	void Attack() {
		animation.Play (attackAnimation);
	}

	void Update () {
		// THIS IS THE ATTACK TRIGGER
		if (Input.GetMouseButton(0)) {
			Attack ();
		}



	}
}
