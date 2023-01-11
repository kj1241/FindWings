using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class endText : MonoBehaviour
{

    public UnityEngine.UI.Text m_Text0;
    public UnityEngine.UI.Text m_Text1;
    public Sprite[] sp = new Sprite[4];
    public UnityEngine.UI.Image TestImage;
    public GameObject gb0;
    public GameObject gb1;



    // Start is called before the first frame update
    void Start()
    {

        

    }

    // Update is called once per frame
    void Update()
    {

        if(mText.coin_cout<=15)
        {
            TestImage.sprite = sp[0];
            m_Text0.text = "뛰어 오느라 힘들었지만\n 결국 해냈다!\n 얻은 것은 튼튼한 근육 뿐…";
            m_Text1.text = "I had a hard time running.\n But I did it finally!\n All I got was strong muscles...";
        }
        else if (mText.coin_cout <= 25&&mText.coin_cout>15)
        {
            TestImage.sprite = sp[1];
            m_Text0.text = "꿈만 같다.\n 자신감으로 마침내 도전 성공!\n 다리가 뻐근한 것은 기분 탓일까.\n 다시 도전하고 싶다!";
            m_Text1.text = "It is like a dream.\n With confidence, I finally succeeded!\n But I feel my legs are stiff.\n I want to try again!";
        }
        else if (mText.coin_cout <= 39 && mText.coin_cout > 25)
        {
            TestImage.sprite = sp[2];
            m_Text0.text = "여린 바람을 타고 날아 온 것 같다.\n 한결 가벼운 다리.\n 난 천사이니까.";
            m_Text1.text = "I think I fly in the soft wind.\n With light legs.\n Because I'm an angel.";
        }
        else if (mText.coin_cout >=40)
        {
            TestImage.sprite = sp[3];
            m_Text0.text = "다시 태어난 순간 같아.\n 이건 꿈일까?\n 아니야, 마침내 나를 찾았어!\n \n 부드러운 바람결에 나를 맡기며\n 자유로운 새들처럼\n 눈부신 태초의 에덴에서\n 영원히 아름다운 나로 살겠어";
            m_Text1.text = "It's like the moment I was born again.\n Is this a dream?\n No, finally I found myself!\n \n Left myself in mild wind.\n Like free birds.\n At Eden in the beginning of a dazzling day,\n I'll be the beautiful me forever.";
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }

    }

    public void pushMakePeople()
    {

        gb0.SetActive(false);
        gb1.SetActive(true);


    }

    public void pushStart()
    {
        SceneManager.LoadScene("start");
    }




}
