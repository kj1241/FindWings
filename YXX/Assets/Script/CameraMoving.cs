using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMoving : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject A;
    Transform AT;
    public float mtime = 1f;

    void Start()
    {
        AT = A.transform;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = Vector3.Lerp(transform.position, AT.position, mtime * Time.deltaTime);
        transform.Translate(0, 0, -10); //카메라를 원래 z축으로 이동
    }
}
