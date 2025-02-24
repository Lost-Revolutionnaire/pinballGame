using UnityEngine;

public class scoreTracker : MonoBehaviour
{
    public Font myFont;
    public int mario = 0;
    public float scoreBonus = 1;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //mario++;
    }

    void OnGUI()
    {
        GUIStyle myStyle = new GUIStyle();
        myStyle.font = myFont;
        myStyle.normal.textColor = Color.white;
        GUI.Label(new Rect(1250, 110, 910, 90), "Score: "+mario+"", myStyle);
    }
}
