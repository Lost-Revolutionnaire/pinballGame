using UnityEngine;

public class imageCircle : MonoBehaviour
{


    public GameObject score;
    public GameObject spriteChanger;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        score = GameObject.Find("scoreTracker");
        spriteChanger = GameObject.Find("imageChanger");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D()
    {
        int numberRolled = Random.Range(0, 100);
        if(numberRolled < 20)
        {
            //Ky
            score.GetComponent<scoreTracker>().scoreBonus = 0.5f;
            spriteChanger.GetComponent<spriteChanger>().character = "ky";
        }
        else if(numberRolled <35) 
        {
            //elphelt
            score.GetComponent<scoreTracker>().scoreBonus = 1.5f;
            spriteChanger.GetComponent<spriteChanger>().character = "elphelt";
        }
        else if(numberRolled < 50)
        {
            //ramlethal
            score.GetComponent<scoreTracker>().scoreBonus = 1.5f;
            spriteChanger.GetComponent<spriteChanger>().character = "ramlethal";
        }
        else if(numberRolled < 65)
        {
            //dizzy
            score.GetComponent<scoreTracker>().scoreBonus = 2f;
            spriteChanger.GetComponent<spriteChanger>().character = "dizzy";
        }
        else if(numberRolled < 80)
        {
            //valentine
            score.GetComponent<scoreTracker>().scoreBonus = 2f;
            spriteChanger.GetComponent<spriteChanger>().character = "valentine";
        }
        else if(numberRolled < 95)
        {
            //jacko
            score.GetComponent<scoreTracker>().scoreBonus = 3f;
            spriteChanger.GetComponent<spriteChanger>().character = "jacko";
        }
        else
        {
            //order sol
            score.GetComponent<scoreTracker>().scoreBonus = 5f;
            spriteChanger.GetComponent<spriteChanger>().character = "orderSol";
            //Why the fuck didn't I use a function for this
        }
    }
}
