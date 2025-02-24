using UnityEngine;

public class lifeCounter : MonoBehaviour
{

    public int lives = 3;

    public Font myFont;
    
    public float scoreBonus = 1;

    public SpriteRenderer spriteRenderer;
    public GameObject score;
    public GameObject spriteChanger;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        score = GameObject.Find("scoreTracker");
        spriteChanger = GameObject.Find("imageChanger");
    }

    void Update()
    {
        if(lives <= 0) {
            spriteRenderer.enabled = true;
            if (Input.GetKeyDown(KeyCode.Return))
            {
                spriteChanger.GetComponent<spriteChanger>().character = "none";
                score.GetComponent<scoreTracker>().mario = 0;
                spriteRenderer.enabled = false;
                lives = 3;
            }
        }
    }

    // Update is called once per frame
    void OnGUI()
    {
        GUIStyle myStyle = new GUIStyle();
        myStyle.font = myFont;
        myStyle.normal.textColor = Color.white;
        GUI.Label(new Rect(1480, 820, 990, 393),  lives + "", myStyle);
    }
}
