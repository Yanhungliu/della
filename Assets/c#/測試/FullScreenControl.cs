using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;   //�ɤJUI API�C



public class FullScreenControl : MonoBehaviour
{


    //�ŧi�@�� Toggle UI�C
    public Toggle SwitchOfScreen;



    void Update()
    {


        //�YToggle�Q�Ŀ�N���������ù����A�C
        if (SwitchOfScreen.isOn)
        {
            Screen.fullScreen = true;
        }


        //�YToggle�Q�����Ŀ�N�������������A�C
        else
        {
            Screen.fullScreen = false;
        }


    }
}