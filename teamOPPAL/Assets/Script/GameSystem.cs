using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameSystem : MonoBehaviour
{
    //スタートボタン押したら実行する
    public void StartGame()
    {
        SceneManager.LoadScene("Tuturial_2");
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
