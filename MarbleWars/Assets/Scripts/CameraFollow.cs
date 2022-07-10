using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    public Transform marble;
    public Vector3 offset;


    void Start() 
    {
        transform.position = marble.position + offset;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = marble.position + offset;
    }
}
