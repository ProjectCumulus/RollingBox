using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaveRanking : MonoBehaviour {

    public Text RankText;
    bool a = false;
    int DataNumber = 1;
    string[] PlayerName=new string[11];
    float[] ClearTime= new float[11];
	// Use this for initialization
	void Start ()
    {
        //Ranking();
        DateCheck();
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    public void DataDelete()
    {

        PlayerPrefs.DeleteAll();
        DataNumber = 1;
    }

    void DatePrint()
    {
        RankText.text= "순위    이름    시간"+ "\n1등: " + PlayerName[1] + " " + ClearTime[1]+ "\n2등: " + PlayerName[2] + " " + ClearTime[2]+ "\n3등: " + PlayerName[3] + " " + ClearTime[3];

    }

    void DateCheck()
    {
        a = true;
        while(a)
        {
            if (PlayerPrefs.HasKey(DataNumber + "번"))
            {
                Debug.Log("Num" + DataNumber + " is exist");
                DataNumber++;
            }
            else
            {
                Debug.Log("Num" + DataNumber + " is not exist");
                a = false;
            }
        }
    }

    public void Ranking()
    {
        for (int i = 1; i < DataNumber; i++)
        {
            PlayerName[i] = PlayerPrefs.GetString(i + "번이름");
            Debug.Log(PlayerPrefs.GetString(i + "번이름"));
            ClearTime[i] = PlayerPrefs.GetFloat(i + "번시간");
        }
        DatePrint();
    }


    public void DataSave()
    {
        PlayerPrefs.SetInt(DataNumber+ "번", DataNumber);
        PlayerPrefs.SetString(DataNumber+ "번이름", "입력이름");
        PlayerPrefs.SetFloat(DataNumber+ "번시간", DataNumber);
        PlayerPrefs.Save();
        Debug.Log("Save "+ DataNumber);
        DataNumber++;
    }
}
