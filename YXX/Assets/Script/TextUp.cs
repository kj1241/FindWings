using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextUp : MonoBehaviour
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
       
            tr.Translate(Vector3.up * moveSpeed * Time.deltaTime);
    }
}
