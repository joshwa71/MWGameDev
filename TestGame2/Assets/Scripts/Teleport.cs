using UnityEngine;
using UnityEngine.UI;

public class Teleport : MonoBehaviour
{

    public Transform teleportTarget;
    public int score = 0;
    private Collider thePlayer;

    void OnTriggerEnter (Collider other) 
    {
        thePlayer = other;
        thePlayer.transform.position = teleportTarget.transform.position;
        score = score + 1;

    }

}
