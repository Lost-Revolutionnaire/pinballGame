using UnityEngine;

public class boostpanel : MonoBehaviour
{
    public float howMuchForce = 3;
    public float forceLeft = 0;
    public GameObject ball;

    public float plusPoints = 100;
    public GameObject scoreMultObj;
    public GameObject score;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ball = GameObject.Find("ball");
        score = GameObject.Find("scoreTracker");
        scoreMultObj = GameObject.Find("scoreTracker");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void OnTriggerEnter2D()
    {
        //Debug.Log("Fuck");
        score.GetComponent<scoreTracker>().mario += (int)(plusPoints * scoreMultObj.GetComponent<scoreTracker>().scoreBonus);
        ball.GetComponent<Rigidbody2D>().linearVelocity = new Vector2(forceLeft, howMuchForce);
    }
}
