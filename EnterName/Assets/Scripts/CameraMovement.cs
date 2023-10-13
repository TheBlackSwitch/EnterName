using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Transform player;
    public float offsetX;
    public float offsetY;
    public float offsetZ;

    void Update()
    {
        transform.position = player.position + new Vector3(offsetX, offsetY, offsetZ);
        transform.LookAt(player);
    }
}
