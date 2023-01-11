using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
    public Sprite CurrentSprite;
    public Sprite NextSprite;
    private SpriteRenderer spriteRenderer;

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        spriteRenderer.sprite = CurrentSprite;

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
    

        if(collision.gameObject.tag=="Player")
            spriteRenderer.sprite = NextSprite;

    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        spriteRenderer.sprite = CurrentSprite ;
    }

}
