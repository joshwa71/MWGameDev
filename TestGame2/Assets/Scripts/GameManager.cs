using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    bool gameHasEnded = false;

    public void EndGame () 
    {
        if(gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("End Game");
            SceneManager.LoadScene("ExitScene");
        }
    }

    void Restart ()
    {
        SceneManager.LoadScene("Track1");
    }
}
