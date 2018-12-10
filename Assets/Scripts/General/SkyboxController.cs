using UnityEngine;
using UnityEngine.UI;

/*
 * Rotates collectible object cubes on an axis
*/
public class SkyboxController : MonoBehaviour
{
	// RPS adjustable through inspector for easy access
	public float RotationPerSecond;

	private Skybox skybox;

	void Start ()
	{
		skybox = GetComponent<Skybox> ();
	}

	void Update ()
	{
		skybox.material.SetFloat ("_Rotation", Time.time * RotationPerSecond);
	}
}