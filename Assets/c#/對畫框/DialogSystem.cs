using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogSystem : MonoBehaviour
{
    public int Take;

    [Header("UI�ե�")]
    public Text textLabel;
    public Image faceImage;

    [Header("�奻���")]
    public TextAsset textFile;
    public int index;
    public float textSpeed;

    [Header("�Y��")]
    public Sprite face01, face02;

    bool textFinished;

    List<string> textList = new List<string>();

    void Awake()
    {
        GetTextFormFile(textFile);
        Take++;
    }
    private void OnEnable()
    {
        //textLabel.text = textList[index];
        //index++;
        textFinished = true;
        StartCoroutine(SetTextUI());
    }

    void Update()
    {

        if(Input.GetKeyDown(KeyCode.F) && index == textList.Count)
        {
            gameObject.SetActive(false);
            index = 0;
            return;
        }
        if (Input.GetKeyDown(KeyCode.F) && textFinished)
        {
            //textLabel.text = textList[index];
            //index++;
            StartCoroutine(SetTextUI());
        }
    }

    void GetTextFormFile(TextAsset file)
    {
        textList.Clear();
        index = 0;

        var lineDate = file.text.Split('\n');

        foreach(var line in lineDate)
        {
            textList.Add(line);
        }
    }
   
    IEnumerator SetTextUI()
    {
        textFinished = false;
        textLabel.text = "";

        switch (textList[index].Trim().ToString())

        {
            case "A":
            faceImage.sprite = face01;
            index++;
            break;
            case "B":
            faceImage.sprite = face02;
            index++;
            break;
        }




        for (int i = 0;i < textList[index].Length; i++)
        {
            textLabel.text += textList[index][i];

            yield return new WaitForSeconds(textSpeed);
        }
        textFinished = true;
        index++;
        
    }
}
