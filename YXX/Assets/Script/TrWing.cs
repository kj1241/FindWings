using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TrWing : MonoBehaviour
{
    private Transform tr;
    public float moveSpeed = 10.0f;
    // Start is called before the first frame update
    void Start()
    {
        tr = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (tr.position.y < 50) 
        tr.Translate(Vector3.up * moveSpeed * Time.deltaTime);
        else
            SceneManager.LoadScene("MainScen");
    }

    public void pushSkip()
    {
        SceneManager.LoadScene("MainScen");
    }
}
