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
        { //�p�G mytext���e�O�Ū�

            mytext.text = "���I�M���[��...."; //�N mytext���e����
        }
        else
        { //�_�h

            mytext.text = ""; //�N mytext���e�令�Ū�

        }

    }
    // Update is called once per frame
    void Update()
    {
        Invoke("NextScences", 2f);

    }
}
