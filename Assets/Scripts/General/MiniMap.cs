using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniMap : MonoBehaviour {

    public Transform player;
    public float desiredHeightAbovePlayer;


    void LateUpdate()
    {
        Vector3 newPosition = player.position;
        newPosition.y += desiredHeightAbovePlayer;
        transform.position = newPosition;

        transform.rotation = Quaternion.Euler(90f, player.eulerAngles.y, 0f);
    }
}
