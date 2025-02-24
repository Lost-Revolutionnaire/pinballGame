using UnityEngine;

public class jackoBall : MonoBehaviour
{

    public float plusPoints = 100;
    public GameObject scoreMultObj;
    public GameObject score;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        score = GameObject.Find("scoreTracker");
        scoreMultObj = GameObject.Find("scoreTracker");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D()
    {
        score.GetComponent<scoreTracker>().mario += (int)(plusPoints * scoreMultObj.GetComponent<scoreTracker>().scoreBonus);

    }

}
