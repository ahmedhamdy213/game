using UnityEngine;

public class real : MonoBehaviour
{
   

    public Rigidbody rb;
    public float forwardforce = 2000f;
    public float slideforce = 500f;


    void FixedUpdate()
    {
        rb .AddForce(0,0 , forwardforce * Time.deltaTime);



        
    }
}

