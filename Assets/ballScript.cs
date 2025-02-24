using UnityEngine;

public class ballScript : MonoBehaviour
{
    public GameObject life;
    public AudioClip shutUp;
    public AudioClip banditRevolver;
    public AudioClip volcanicViper;
    public AudioClip gunflame;
    public AudioClip dragonInstall;
    public AudioSource aud;


    Vector3 originalPos;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        originalPos = gameObject.transform.position;
        life = GameObject.Find("lifeCounter");
        aud = GetComponent<AudioSource>();
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

        if (transform.position.y <= -30)
        {
            if(life.GetComponent<lifeCounter>().lives > 1)
            {

                gameObject.transform.position = originalPos;
                GetComponent<Rigidbody2D>().linearVelocity = Vector2.zero;
                //GetComponent<Rigidbody2D>().angularVelocity = Vector2.zero;}

                life.GetComponent<lifeCounter>().lives--;
            }
            else if (life.GetComponent<lifeCounter>().lives > 0)
            {
                life.GetComponent<lifeCounter>().lives--;
            }
            else
            {
                
                if (Input.GetKeyDown(KeyCode.Return))
                {
                    gameObject.transform.position = originalPos;
                    GetComponent<Rigidbody2D>().linearVelocity = Vector2.zero;
                    //GetComponent<Rigidbody2D>().angularVelocity = Vector2.zero;}
                }
            }
            

        }
    }

    void OnCollisionEnter2D()
    {
        int randomSound = Random.Range(0, 100);
        if(randomSound < 20)
        {
            aud.PlayOneShot(shutUp, 0.7f);
        }
        else if (randomSound < 40)
        {
            aud.PlayOneShot(banditRevolver, 0.7f);
        }
        else if (randomSound < 60)
        {
            aud.PlayOneShot(volcanicViper, 0.7f);
        }
        else if (randomSound < 80)
        {
            aud.PlayOneShot(gunflame, 0.7f);
        }
        else
        {
            aud.PlayOneShot(dragonInstall, 0.7f);
        }

    }
}
