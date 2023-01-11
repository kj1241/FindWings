using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class coin : MonoBehaviour
{
    public GameObject player;


    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if( AabbAabbIntersection(gameObject, player)==true)
        {
            mText.coin_cout += 1;
            Destroy(gameObject);
        }



    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
     

    }


    bool AabbAabbIntersection(GameObject a, GameObject b)
    {
     
        if (a.transform.position.x + 0.5 < b.transform.position.x - 0.5 || a.transform.position.x - 0.5 > b.transform.position.x + 0.5)
            return false;
   
        if (a.transform.position.y + 0.5 < b.transform.position.y - 1.5 || a.transform.position.y - 0.5 > b.transform.position.y+ 1.5)    
            return false;
           
                

        return true;
    }




}
