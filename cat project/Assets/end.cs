using UnityEngine;

public class end : MonoBehaviour
{
    public Game game;
   void OnTriggerEnter()
    {

        game.CompleteLevel();


    }
}
