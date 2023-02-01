using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardforce = 2000f;
    public float slideforce = 500f;


    void FixedUpdate()
    {
        rb .AddForce(0,0 , forwardforce * Time.deltaTime);



        if ( Input.GetKey("d") )
        {
            rb.AddForce (slideforce * Time.deltaTime , 0, 0, ForceMode.VelocityChange);


        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-slideforce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);


        }
        if (rb.position.y<-1f) {

            FindObjectOfType<Game>().Endgame();


        }
    }
}
