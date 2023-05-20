using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShadowSprite : MonoBehaviour
{
    private Transform player;

    private SpriteRenderer thisSprite; //��ǰ�D��
    private SpriteRenderer playerSprite; //��҈D��

    private Color color;// 1��100%

    [Header("�r�g���ƅ���")]
    public float activeTime; //�@ʾ�r�g
    public float activeStart; //�_ʼ�@ʾ�r�g�c

    [Header("��͸���ȿ���")]
    private float alpha;
    public float alphaSet;//��ʼֵ
    public float alphaMultiplier;     


    private  void OnEnable()  //�n�̚�Ӱ
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        thisSprite = GetComponent<SpriteRenderer>();
        playerSprite = player.GetComponent<SpriteRenderer>();

        alpha = alphaSet;

        thisSprite.sprite = playerSprite.sprite;

        transform.position = player.position;
        transform.localScale = player.localScale;
        transform.rotation = player.rotation;

        activeStart = Time.time;
    }

    void Update()
    {
        alpha *= alphaMultiplier;

        color = new Color(0, 0, 1, alpha); //(0,0,1)��ɫ

        thisSprite.color = color;

        if(Time.time >= activeStart + activeTime)
        {
            //���،����
            ShadowPool.instance.ReturnPool(this.gameObject);
        }
    }
}
