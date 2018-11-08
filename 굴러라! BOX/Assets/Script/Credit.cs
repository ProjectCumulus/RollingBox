using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Credit : MonoBehaviour
{
    //public GameObject credit1, credit2;

    public Text Credit_Text;
    public Image Na;

    // Use this for initialization
    void Start()
    {
        StartCoroutine(CreditTextPrint());

    }

    IEnumerator AP()
    {
        while(Credit_Text.color.a<1)
        {
            Credit_Text.color += new Color(0, 0, 0, 0.1f);
            yield return new WaitForFixedUpdate();
        }
        Credit_Text.color = new Color(1, 1, 1, 1);
    }

    IEnumerator AM()
    {
        while (Credit_Text.color.a > 0)
        {
            Credit_Text.color -= new Color(0, 0, 0, 0.1f);
            yield return new WaitForFixedUpdate();
        }
        Credit_Text.color = new Color(1, 1, 1, 0f);
    }

    IEnumerator IAP()
    {
        while (Na.color.a < 1)
        {
            Na.color += new Color(0, 0, 0, 0.1f);
            yield return new WaitForFixedUpdate();
        }
        Na.color = new Color(1, 1, 1, 1);
    }

    IEnumerator IAM()
    {
        while (Na.color.a > 0)
        {
            Na.color -= new Color(0, 0, 0, 0.1f);
            yield return new WaitForFixedUpdate();
        }
        Na.color = new Color(1, 1, 1, 0f);
    }

    IEnumerator CreditTextPrint()
    {
        Credit_Text.color = new Color(1, 1, 1, 0f);
        Na.color = new Color(1, 1, 1, 0f);
        yield return new WaitForSeconds(3.0f);
        Credit_Text.fontSize = 60;
        StartCoroutine(IAP());
        StartCoroutine(AP());
        Credit_Text.text = "Credit";
        yield return new WaitForSeconds(2.5f);
        StartCoroutine(AM());
        yield return new WaitForSeconds(0.5f);
        StartCoroutine(AP());
        Credit_Text.text = "Team 뭉게구름";
        yield return new WaitForSeconds(3f);
        StartCoroutine(AM());
        yield return new WaitForSeconds(0.5f);
        StartCoroutine(AP());
        Credit_Text.fontSize = 36;
        Credit_Text.text = "시스템 개발      김진혁 ";
        yield return new WaitForSeconds(1.5f);
        StartCoroutine(AM());
        yield return new WaitForSeconds(0.5f);
        StartCoroutine(AP());
        Credit_Text.text = "레벨 디자인      위하은 ";
        yield return new WaitForSeconds(1.5f);
        StartCoroutine(AM());
        yield return new WaitForSeconds(0.5f);
        StartCoroutine(AP());
        Credit_Text.text = "그래픽 디자인 및 기획\n서유란, 최예슬 ";
        yield return new WaitForSeconds(1.5f);
        StartCoroutine(AM());
        yield return new WaitForSeconds(0.5f);
        StartCoroutine(AP());
        Credit_Text.text = "시스템 기획      김진혁 ";
        yield return new WaitForSeconds(1.5f);
        StartCoroutine(AM());
        yield return new WaitForSeconds(0.5f);
        StartCoroutine(AP());
        Credit_Text.text = "밸런싱           위하은 ";
        yield return new WaitForSeconds(1.5f);
        StartCoroutine(AM());
        yield return new WaitForSeconds(0.5f);
        StartCoroutine(AP());
        Credit_Text.text = "스토리 기획\n최예슬, 위하은, 김진혁, 서유란 ";
        yield return new WaitForSeconds(1.5f);
        StartCoroutine(AM());
        yield return new WaitForSeconds(0.5f);
        StartCoroutine(AP());
        Credit_Text.text = "스토리 스크립트\n최예슬, 위하은, 서유란 ";
        yield return new WaitForSeconds(1.5f);
        StartCoroutine(AM());
        yield return new WaitForSeconds(0.5f);
        StartCoroutine(AP());
        Credit_Text.text ="게임 디렉팅      김진혁";
        yield return new WaitForSeconds(1.5f);
        StartCoroutine(AM());
        yield return new WaitForSeconds(0.5f);
        StartCoroutine(AP());
        Credit_Text.fontSize = 60;
        Credit_Text.text = "Thank For";
        yield return new WaitForSeconds(1.5f);
        StartCoroutine(AM());
        yield return new WaitForSeconds(0.5f);
        StartCoroutine(AP());
        Credit_Text.fontSize = 36;
        Credit_Text.text = "Open Source\n" +
            "캐릭터 이동 - C.J. Kimberlin - GitHub \n " +
            "HP UI - tankandhealerstudio - Unity Asset Store";
        yield return new WaitForSeconds(2.5f);
        StartCoroutine(AM());
        yield return new WaitForSeconds(0.5f);
        StartCoroutine(AP());
        Credit_Text.text = " Sprite\n" +
            "KeyIcon - Icon made by Freepik\n " +
            "ChatBubble - Created by Freepik";
        yield return new WaitForSeconds(2.5f);
        StartCoroutine(AM());
        yield return new WaitForSeconds(0.5f);
        StartCoroutine(AP());
        Credit_Text.fontSize = 32;
        Credit_Text.text = " Sound\n " +
            "앱센터효과음 - gongu.copyright.or.kr/ by AppCenter\n" +
            "Malicious - incompetech.com by Kevin MacLeod\n" +
            "another magic wand spell tinkle - freesound.org/s/221683 by Timbre \n";
        yield return new WaitForSeconds(2.5f);
        StartCoroutine(AM());
        yield return new WaitForSeconds(0.5f);
        StartCoroutine(AP());
        Credit_Text.fontSize = 36;
        Credit_Text.text = "당신은 " + Global.PresentTime.ToString("##0.0") + "시간 동안 달려 적의 폭격에서 마을을 구했습니다.";
        yield return new WaitForSeconds(3.5f);
        StartCoroutine(AM());
        yield return new WaitForSeconds(0.5f);
        StartCoroutine(AP());
        Credit_Text.fontSize = 60;
        Credit_Text.text = "당신은 영웅입니다.";
        yield return new WaitForSeconds(3.5f);
        StartCoroutine(AM());
        StartCoroutine(IAM());
        yield return new WaitForSeconds(2.0f);
        SceneManager.LoadScene("MainScreen");
    }

    void Update()
    {

    }

}
