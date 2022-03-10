using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;

    public float forwardForce = 2000f;
    public float sidewayForce = 500f;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello World");
    }

    // When Doing changes that are fixed such as gravity,  
    void FixedUpdate() //it's better to use FixedUpdate instead of Update
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime); // over here Time.deltaTime is for all screens,
                                                 //Because of FPS rates this could seem different with this code we prevent that
        if( Input.GetKey("d") )
        {
            rb.AddForce(sidewayForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if( Input.GetKey("a") )
        {
            rb.AddForce(-sidewayForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }

    }
}
