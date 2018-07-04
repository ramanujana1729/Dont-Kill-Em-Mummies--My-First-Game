
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    //This is a reference to rigidbody called 'Rb'
    public Rigidbody Rb;
    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;

    // Update is called once per frame
    // WE are usinf fixed update because we 
    // are using it to mess with physics.
    void FixedUpdate () {
        //Add a forwardforce
        Rb.AddForce(0,0, forwardForce * Time.deltaTime);

        if (Rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }

    }
    void Update()
    {

        if (Input.GetKey("d"))
        {
            Rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0,ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {
            Rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

    }
}
