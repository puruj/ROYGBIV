using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Controls the movement of the rocks in Level 2 as well as their interaction with the player
 * Based on https://www.youtube.com/watch?v=9oVMV_flbvA
*/
public class Level2Rocks : MonoBehaviour
{
	public Transform player;

	public Transform rock;

	// Initial position of rock
	public Vector3 startPosition;

	// Final position of rock
	public Vector3 newPosition;

	// Time for rock to move from initial position to final position
	public float smooth;

	void Start ()
	{
		startPosition = rock.position; // Set initial position
		newPosition.y = startPosition.y; // Ensure no change in y
		newPosition.z = startPosition.z; // Ensure no change in z
		startPosition.x = 25; // So that they reset each time at x = 25
	}

	void FixedUpdate ()
	{
		// If rock reaches final position
		if (rock.position.x <= -21) {
			rock.position = startPosition; // Reset rock to initial position
		} else {
			rock.position = Vector3.Lerp (rock.position, newPosition, smooth * Time.deltaTime); // Slowly move rock to final position
		}
	}

	void OnTriggerEnter (Collider col)
	{
		// If player lands on rock
		if (col.name == "Player") {				
			col.transform.parent = transform; // Player moves with rock
		}
	}

	void OnTriggerExit (Collider col)
	{
		// If player jumps off rock
		if (col.name == "Player") {
			col.transform.parent = null; // Player no longer moves with rock
		}
	}
}