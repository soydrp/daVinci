using UnityEngine;
using System.Collections;
using Character;


public class MoveLookAtMe : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        KeyboardController.Move(transform);
    }
}
