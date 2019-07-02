using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Clear : MonoBehaviour
{
    private GameObject[] enemyObj;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Enemyタグをまとめる
        enemyObj = GameObject.FindGameObjectsWithTag("Enemy");

        //データの入った箱の数をコンソール画面に表示
        //print(enemyObj.Length);

        //0になったらクリア
        if (enemyObj.Length == 0)
        {
            SceneManager.LoadScene(SceneManager.sceneCount+1);
        }
    }
}
