using UnityEngine;
using UnityEngine.SceneManagement;

public class Game : MonoBehaviour{

    bool GameHasEnded = false;
    public float restarDelay = 1f;
    public void CompleteLevel()
    {

        Debug.Log("LEVEL WON");

    }
    public void Endgame() 

    {
        if (GameHasEnded == false)
        {

            GameHasEnded = true;
            Debug.Log("GAME OVER ");
            Invoke("Restart", restarDelay);
            
        }
        

    }
   void Restart()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }
}
