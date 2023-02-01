using UnityEngine;

public class NewBehaviourScript1 : MonoBehaviour
{



    public NewBehaviourScript movement;
    

    void OnCollisionEnter (Collision collisionInfo)
    {
        

        if(collisionInfo.collider. tag == "Cube")
        {

            movement.enabled  = false;

            FindObjectOfType<Game>().Endgame();
            
        } 



    }



}
