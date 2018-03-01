using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public Rigidbody rigidBody;
    public float forwardForce = 5500f;
    public float inputForce = 120f;
	
	// Update is called once per frame
    // FixedUpdate is used because it deals better with physics, which
    // is what I need right now!
	void FixedUpdate () {
        // Add a forwards force
        rigidBody.AddForce(0, 0, forwardForce * Time.deltaTime);
        bool rightPressed = Input.GetKey("d") || Input.GetKey(KeyCode.RightArrow);
        bool leftPressed = Input.GetKey("a") || Input.GetKey(KeyCode.LeftArrow);
           
        // Player input
        if (rightPressed) {
            // Add a force to the right
            rigidBody.AddForce(inputForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        } else if (leftPressed) {
            // Add a force to the left
            rigidBody.AddForce(-inputForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        // Added a higher force to speed up the player to make it harder
        forwardForce += 10f;

        if (rigidBody.position.y <= -1f) {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
