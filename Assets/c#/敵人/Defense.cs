using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Defense : MonoBehaviour
{

    public GameObject Enemy;
    public Transform left;
    public Transform right;
    public int wave;
    public int timer;



    // Start is called before the first frame update
    public void Start()
    {

        StartCoroutine(SpawnEnemy());

    }



    IEnumerator SpawnEnemy()
    {


        //TODO:�Д����ȫ������ ����waveֱ��׃0Ȼ��ȫ��Enemy������ 
        while (wave > 0)
        {
            if (wave % 2 == 0)//ż���� 
            {
                Instantiate(Enemy, right.position, Quaternion.identity);
                yield return new WaitForSeconds(timer);
                wave -= 1;

            }
            else
            {

                Instantiate(Enemy, left.position, Quaternion.identity);
                yield return new WaitForSeconds(timer);
                wave -= 1;
            }




        }




    }
}

