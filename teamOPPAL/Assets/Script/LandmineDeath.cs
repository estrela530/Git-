using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LandmineDeath : MonoBehaviour
{
    //public GameObject LandmiinePrefab;
    Vector3 origin1;
    Vector3 directions;
    List<GameObject> deathobjectlist = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //GameObject player = GameObject.FindGameObjectWithTag("Player");
        //Destroy(player);
        //GameObject enemy = GameObject.FindGameObjectWithTag("Enemy");
        //Destroy(enemy);
        GameObject fragileWall = GameObject.FindGameObjectWithTag("FragileWall");
        Destroy(fragileWall); 
        //GameObject fragileWall = GameObject.FindGameObjectWithTag("FragileWall");
        //Destroy(fragileWall);
    }

    void OnCollisionStay(Collision collision)
    {
        //if (collision.gameObject.CompareTag("Player") || collision.gameObject.CompareTag("Enemy")
        //    || collision.gameObject.CompareTag("fragileWall"))
        //{
        //    Debug.Log("if来たよ");
        //    deathobjectlist.Add(collision.gameObject);
        //    //Destroy(collision.gameObject);
        //}

        //foreach (var deathgameObject in collision.contacts)
        //{
        Debug.Log("if来たよ");
        //}
    }

    //void OnCollisionEnter(Collision collision)
    //{
    //    if (collision.gameObject.CompareTag("Player"))
    //    {
    //        Destroy(collision.gameObject);
    //    } 
    //}

    //public void ShooyRay()
    //{
    //    origin1 = transform.position;

    //    RaycastHit hit;

    //    if (Physics.Raycast(origin1,direction,out hit))
    //    {
    //        Debug.DrawLine(transform.position, hit.point, Color.green);
    //    }
    //}

    //static Vector3 pos = new Vector3(0.0f, 10.0f, 0.0f);
    //static Vector3 direction = new Vector3(0.0f, -1.0f, 0.0f);
    //Ray ray = new Ray(pos, direction);
    //RaycastHit[] hit_list;
    //float max_distance = 10.0f;


}
