using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stage5tile : MonoBehaviour
{
    public Sprite CurrentSprite;
    public Sprite NextSprite;
    private SpriteRenderer spriteRenderer;

    public GameObject Object;
    public bool btiem = false;
    public float time = 2.0f;



    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(CountTime());
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        if(btiem == false)
        {
            spriteRenderer.sprite = CurrentSprite;
            Object.SetActive(false);

        }
        else
        {
            spriteRenderer.sprite = NextSprite;
            Object.SetActive(true);
        }

    }

    // Update is called once per frame
    void Update()
    {
        if(btiem==true)
        {
            spriteRenderer.sprite = NextSprite;
            Object.SetActive(true);
        }
        else if(btiem==false)
        {
            spriteRenderer.sprite = CurrentSprite;
            Object.SetActive(false);
        }

    }

    IEnumerator CountTime()
    {
        if (btiem == false)
        {
            btiem = true;
            
        }
        else
        {
            btiem = false;
           
        }
           

        yield return new WaitForSecondsRealtime(time);
        StartCoroutine(CountTime());
    }

}
