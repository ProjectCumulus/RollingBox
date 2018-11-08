using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Credit : MonoBehaviour
{
    //public GameObject credit1, credit2;

    public Text Credit_Text;
    
   
    // Use this for initialization
    void Start()
    {
        StartCoroutine(CreditTextPrint());
        

    }

    IEnumerator CreditTextPrint()
    {
        yield return new WaitForSeconds(2.0f);
        Credit_Text.text = "\n팀명\n▶뭉게구름";
        yield return new WaitForSeconds(5.0f);
        Credit_Text.text = "\n조원\n▶김진혁 - 전반적인 코드 작성\n▶서유란 - 디자인\n▶위하은 - 스프라이트 배치 및 조정\n▶최예슬 - 디자인";
        yield return new WaitForSeconds(5.0f);
        Credit_Text.text = "\nThank For";
        yield return new WaitForSeconds(5.0f);
        Credit_Text.text = "\n오픈소스\n▶상자 이동 - https://github.com/cjddmut/Unity-2D-Platformer-Controller\n▶HP UI - tankandhealerstudio";
        yield return new WaitForSeconds(5.0f);
        Credit_Text.text = "\n이미지\n▶방향키 - Icon made by Freepik from www.flaticon.com\n▶말풍선 - Created by Freepik";
        yield return new WaitForSeconds(5.0f);
        Credit_Text.text = "\nSound\n▶앱센터\nStage1, Laser, Book, Sword, Mine, Bombing, AIrplane, Move, Death, Button";
        yield return new WaitForSeconds(5.0f);
        Credit_Text.text = "\n▶Kevin MacLeod (incompetech.com)\nMalicious(Stage4)\n▶Timbre(https://freesound.org/s/221683/)\nanother magic wand spell tinkle(Recovery)";
        yield return new WaitForSeconds(5.0f);
        Credit_Text.text = "\n프리소스\n▶Northen_LIghts(MainScreen)\n▶White_Hats(Stage2)\n▶Spirit of the Dead(Stage3)\n▶water throw stone1(Water)\n▶paper tear3(Damaged)";
        yield return new WaitForSeconds(5.0f);
    }

    void Update()
    {

    }

}
