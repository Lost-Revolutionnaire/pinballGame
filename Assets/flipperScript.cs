using UnityEngine;

public class flipperScript : MonoBehaviour
{

    Rigidbody2D rb;
    public int forceMagnifier = 1;

    public HingeJoint2D hingeJoint2D;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            rb.AddTorque(25f*forceMagnifier);
        }
        else {
            rb.AddTorque(-20f*forceMagnifier);
        }
    }
}
