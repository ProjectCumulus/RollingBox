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
        Credit_Text.text = "곧 폭격이 시작될겁니다!";
        chat1.gameObject.SetActive(true);
        yield return new WaitForSeconds(2.0f);
        chat1.gameObject.SetActive(false);
        Credit_Text.gameObject.SetActive(false);

        yield return new WaitForSeconds(3.0f);
        chat1.gameObject.SetActive(true);
        Credit_Text.gameObject.SetActive(true);
        Credit_Text.text = "빨리 대피해야 합니다!";
        yield return new WaitForSeconds(2.0f);
        chat1.gameObject.SetActive(false);
        Credit_Text.gameObject.SetActive(false);

        yield return new WaitForSeconds(3.0f);
        chat1.gameObject.SetActive(true);
        Credit_Text.gameObject.SetActive(true);
        Credit_Text.text = "지금 도망 쳐야 합니다!";
        yield return new WaitForSeconds(2.0f);
        chat1.gameObject.SetActive(false);
        Credit_Text.gameObject.SetActive(false);

        yield return new WaitForSeconds(3.0f);
        chat1.gameObject.SetActive(true);
        Credit_Text.gameObject.SetActive(true);
        Credit_Text.text = "절 따라 오세요!";
        yield return new WaitForSeconds(2.0f);
        chat1.gameObject.SetActive(false);
        Credit_Text.gameObject.SetActive(false);

        yield return new WaitForSeconds(3.0f);
        chat1.gameObject.SetActive(true);
        Credit_Text.gameObject.SetActive(true);
        Credit_Text.text = "폭격이 시작될겁니다!";
        yield return new WaitForSeconds(2.0f);
        chat1.gameObject.SetActive(false);
        Credit_Text.gameObject.SetActive(false);

        yield return new WaitForSeconds(3.0f);
        chat1.gameObject.SetActive(true);
        Credit_Text.gameObject.SetActive(true);
        Credit_Text.text = "시간이 없어요 빨리 나오세요!";
        yield return new WaitForSeconds(2.0f);
        chat1.gameObject.SetActive(false);
        Credit_Text.gameObject.SetActive(false);
    }
}
