using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class endScene : MonoBehaviour
{

    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(AabbAabbIntersection(gameObject, player)==true)
        {
            SceneManager.LoadScene("endScen");
                    }
    }

    bool AabbAabbIntersection(GameObject a, GameObject b)
    {

        if (a.transform.position.x + 0.5 < b.transform.position.x - 0.5 || a.transform.position.x - 0.5 > b.transform.position.x + 0.5)
            return false;

        if (a.transform.position.y + 0.5 < b.transform.position.y - 1.5 || a.transform.position.y - 0.5 > b.transform.position.y + 1.5) 
            return false;



        return true;
    }
}
