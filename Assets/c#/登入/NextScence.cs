using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NextScence : MonoBehaviour
{


    public Text mytext;
    public Image myImage;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("showHide", 0.5f, 0.5f);
    }

    void NextScences()
    {
        if (Input.anyKeyDown)
        {
            SceneManager.LoadScene(1);
        }
    }


    void showHide()
    {

        if (mytext.text == "")
        { //如果 mytext內容是空的

            mytext.text = "偌潬筳�錈[��...."; //將 mytext內容改變
        }
        else
        { //否則

            mytext.text = ""; //將 mytext內容改成空的

        }

    }
    // Update is called once per frame
    void Update()
    {
        Invoke("NextScences", 2f);

    }
}
