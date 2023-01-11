using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class mText : MonoBehaviour
{
    public UnityEngine.UI.Text m_Text;
    public static int coin_cout;
    // Start is called before the first frame update
    void Start()
    {
        coin_cout = 0;


    }

    // Update is called once per frame
    void Update()
    {
        m_Text.text = "X" + coin_cout.ToString();
    }
}
