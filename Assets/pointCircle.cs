using UnityEngine;

public class pointCircle : MonoBehaviour
{
    public float plusPoints = 200;


    public GameObject scoreMultObj;
    public GameObject life;

    public CircleCollider2D col;
    public SpriteRenderer spriteRenderer;


    public GameObject score;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        score = GameObject.Find("scoreTracker");
        scoreMultObj = GameObject.Find("scoreTracker");
        life = GameObject.Find("lifeCounter");
        col = GetComponent<CircleCollider2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();

    }

    // Update is called once per frame
    void Update()
    {
        
        if(life.GetComponent<lifeCounter>().lives == 0)
        {
            col.enabled = true;
            spriteRenderer.enabled = true;
        }

    }

    void OnCollisionEnter2D()
    {
        score.GetComponent<scoreTracker>().mario += (int)(plusPoints * scoreMultObj.GetComponent<scoreTracker>().scoreBonus);
        col.enabled = false;
        spriteRenderer.enabled = false;
    }
}
