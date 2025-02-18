using UnityEngine;

public class ballScript : MonoBehaviour
{

    Vector3 originalPos;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        originalPos = gameObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.R))
        {
            gameObject.transform.position = originalPos;
            GetComponent<Rigidbody2D>().linearVelocity = Vector2.zero;
            //GetComponent<Rigidbody2D>().angularVelocity = Vector2.zero;
        }
    }
}
