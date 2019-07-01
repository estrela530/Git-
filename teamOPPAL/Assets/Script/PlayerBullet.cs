using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBullet : MonoBehaviour
{
    public float shotTime;
    public GameObject TamaPrefab;
    public int TamaLimit;
   
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Shot"))
        { 
            //TamaLimit += 1;
            //if (TamaLimit <= 5)
            //{
                Shot();
            //}
        }
        
    }

    void Shot()
    {
        GameObject Tama = Instantiate(TamaPrefab, transform.position, transform.rotation);
        Rigidbody tamarigidbody = Tama.GetComponent<Rigidbody>();
        tamarigidbody.AddForce(transform.forward * shotTime);
        
    }
}
