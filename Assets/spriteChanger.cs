using UnityEngine;

public class spriteChanger : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public string character = "none";
    public Sprite ky;
    public Sprite ramlethal;
    public Sprite elphelt;
    public Sprite dizzy;
    public Sprite valentine;
    public Sprite jacko;
    public Sprite orderSol;
    public Sprite noBonus;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if(character == "ky")
        {
            spriteRenderer.sprite = ky;
        }
        if (character == "elphelt")
        {
            spriteRenderer.sprite = elphelt;
        }
        if (character == "ramlethal")
        {
            spriteRenderer.sprite = ramlethal;
        }
        if (character == "dizzy")
        {
            spriteRenderer.sprite = dizzy;
        }
        if (character == "valentine")
        {
            spriteRenderer.sprite = valentine;
        }
        if (character == "jacko")
        {
            spriteRenderer.sprite = jacko;
        }
        if (character == "orderSol")
        {
            spriteRenderer.sprite = orderSol;
        }
        if(character == "none")
        {
            spriteRenderer.sprite = noBonus;
        }

    }
}
