using UnityEngine;
using System.Collections;

public class CCTV : MonoBehaviour {

    public float maxRotation = 75F;
    public float rotationSpeed = 15;

	// Reference to the player.
    GameObject player;
    // Reference to the global last sighting of the player.
    // The joint the camera rotates around.
    GameObject jointObject;
    Transform joint;
    Quaternion initialRotation;
    float angle;

	void Start() {
		// Setting up the references.
		player = GameObject.FindGameObjectWithTag("Player");
        jointObject = GameObject.FindGameObjectWithTag("joint");
        joint = jointObject.transform;
        initialRotation = joint.rotation;
    }

    void Update() {
        joint.Rotate(new Vector3(0, rotationSpeed * Time.deltaTime, 0));
        if (Quaternion.Angle(initialRotation, joint.rotation) >= maxRotation) {
            rotationSpeed *= -1;
        }
    }
	
	void OnTriggerStay(Collider other) {
		// If the colliding gameobject is the player.
		if (other.gameObject == player) {
            print("Player Detected");
		}
	}
}
