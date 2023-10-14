using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Transform player; //importeerd de positie van de speler
    public float offsetX;    //maak 3 variabelen zodat je de offset kan tweaken
    public float offsetY;
    public float offsetZ;

    void Update()
    {
        transform.position = player.position + new Vector3(offsetX, offsetY, offsetZ); //zet de camera positie gelijk aan de spele positie + de offset
        transform.LookAt(player); //laat de camera naar de speler kijken
    }
}
