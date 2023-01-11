using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpBar : MonoBehaviour
{
    public GameObject fullFillImage;
    static public bool bjum=false;


    float temp;

    void Start()
    {
        fullFillImage.transform.localScale = new Vector3(0,1,1);
    }
    private void Update()
    {

        if (bjum == true)
        {
            fullFillImage.transform.localScale = new Vector3(0, 1, 1);
            bjum = false;

        }

        Vector3 newScale = fullFillImage.transform.localScale;
        newScale.x = fullFillImage.transform.localScale.x + Time.deltaTime * 8 / 10;

        



            if (newScale.x > 1)
                newScale.x = 1.0f;
            fullFillImage.transform.localScale = newScale;



     


    }


    public void fufillZoro()
    {

        fullFillImage.transform.localScale = new Vector3(0,1,1);

    }

}
