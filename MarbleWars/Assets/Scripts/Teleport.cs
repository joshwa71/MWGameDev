using UnityEngine;
using UnityEngine.UI;

public class Teleport : MonoBehaviour
{

    public Transform teleportTarget;
    public GameObject thePlayer;
    public int score = 0;

    void OnTriggerEnter (Collider other) 
    {
        thePlayer.transform.position = teleportTarget.transform.position;

    }

}
