using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{

    Teleport endzone;
    public GameObject Endzone;
    public Text scoreText;

    // Update is called once per frame
    void Awake()
    {
        endzone = Endzone.GetComponent<Teleport>();
    }

    void Update()
    {
        scoreText.text = "Score = " + endzone.score.ToString();
    }
}
