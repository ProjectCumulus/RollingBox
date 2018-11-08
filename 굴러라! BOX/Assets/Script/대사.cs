using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class 대사 : MonoBehaviour {

    public Text Credit_Text;
    public Image chat1;

    void Start () {
        StartCoroutine(Chat_B());
        chat1.gameObject.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    IEnumerator Chat_B()
    {
        yield return new WaitForSeconds(3.0f);
        chat1.gameObject.SetActive(true);
        Credit_Text.text = "주민 여러분!";
        yield return new WaitForSeconds(1.5f);
        Credit_Text.text = "곧 폭격이 시작될겁니다!";
        yield return new WaitForSeconds(1.5f);
        chat1.gameObject.SetActive(false);
        Credit_Text.gameObject.SetActive(false);

        yield return new WaitForSeconds(2.0f);
        chat1.gameObject.SetActive(true);
        Credit_Text.gameObject.SetActive(true);
        Credit_Text.text = "저를 따라 마을에서 벗어나야합니다!";
        yield return new WaitForSeconds(1.5f);
        Credit_Text.text = "빨리 저를 따라오세요!";
        yield return new WaitForSeconds(1.5f);
        chat1.gameObject.SetActive(false);
        Credit_Text.gameObject.SetActive(false);

        yield return new WaitForSeconds(2.0f);
        chat1.gameObject.SetActive(true);
        Credit_Text.gameObject.SetActive(true);
        Credit_Text.text = "마을에 있다간 모두 죽습니다!";
        yield return new WaitForSeconds(2.0f);
        chat1.gameObject.SetActive(false);
        Credit_Text.gameObject.SetActive(false);

        yield return new WaitForSeconds(2.0f);
        chat1.gameObject.SetActive(true);
        Credit_Text.gameObject.SetActive(true);
        Credit_Text.text = "빨리 숲으로 이동하지 않으면 위험합니다!";
        yield return new WaitForSeconds(2.0f);
        chat1.gameObject.SetActive(false);
        Credit_Text.gameObject.SetActive(false);

        yield return new WaitForSeconds(4.0f);
        chat1.gameObject.SetActive(true);
        Credit_Text.gameObject.SetActive(true);
        Credit_Text.text = "폭격이 시작될겁니다!";
        yield return new WaitForSeconds(2.0f);
        chat1.gameObject.SetActive(false);
        Credit_Text.gameObject.SetActive(false);

        yield return new WaitForSeconds(3.0f);
        chat1.gameObject.SetActive(true);
        Credit_Text.gameObject.SetActive(true);
        Credit_Text.text = "폭격이다!";
        yield return new WaitForSeconds(2.0f);
        chat1.gameObject.SetActive(false);
        Credit_Text.gameObject.SetActive(false);
    }
}
