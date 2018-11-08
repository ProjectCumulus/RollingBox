using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Credit : MonoBehaviour
{
    //public GameObject credit1, credit2;

    public Text Credit_Text;
    public GameObject DataSave;

    // Use this for initialization
    void Start()
    {
        DataSave.gameObject.SetActive(false);
        StartCoroutine(CreditTextPrint());

    }

    IEnumerator CreditTextPrint()
    {
        yield return new WaitForSeconds(2.0f);
        Credit_Text.text = "\n팀명\n뭉게구름";
        yield return new WaitForSeconds(5.0f);
        Credit_Text.text = "\n조원\n김진혁 - 전반적인 코드 작성\n서유란 - 디자인\n위하은 - 스프라이트 배치 및 조정\n최예슬 - 디자인";
        yield return new WaitForSeconds(5.0f);
        Credit_Text.text = "\nThankfor";
        yield return new WaitForSeconds(5.0f);
        Credit_Text.text = "\n오픈소스\n상자 이동 - https://github.com/cjddmut/Unity-2D-Platformer-Controller\nHP UI - tankandhealerstudio";
        yield return new WaitForSeconds(5.0f);
        Credit_Text.text = "\n이미지\n방향키 - Icon made by Freepik from www.flaticon.com\n말풍선 - Created by Freepik";
        yield return new WaitForSeconds(5.0f);
        Credit_Text.text = "\nSound\n앱센터\nStage1 - 앱센터효과음2_655\nLaser - 앱센터효과음2_133\nBook - 앱센터효과음2_014\nSword - 앱센터효과음2_510\nMine - 앱센터효과음2_591\nBombing - 앱센터효과음2_625\nAIrplane - 앱센터효과음2_429";
        yield return new WaitForSeconds(5.0f);
        Credit_Text.text = "\nMove - 앱센터효과음2_423\nDeath - 디지털소리_효과음313\nButton - 디지털소리_효과음307";
        yield return new WaitForSeconds(5.0f);
        Credit_Text.text = "\nKevin MacLeod (incompetech.com)\nStage4 - Malicious";
        yield return new WaitForSeconds(5.0f);
        Credit_Text.text = "\nTimbre(https://freesound.org/s/221683/)\nRecovery - another magic wand spell tinkle";
        yield return new WaitForSeconds(5.0f);
        Credit_Text.text = "\n프리소스\nMainScreen - Northen_LIghts\nStage2 - White_Hats\nStage3 - Spirit of the Dead\nWater - water throw stone1\nDamaged - paper tear3";
        yield return new WaitForSeconds(5.0f);
        DataSave.gameObject.SetActive(true);

    }

    void Update()
    {

    }

}
