using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBullet : MonoBehaviour
{
    public float shotTime;
    public GameObject TamaPrefab;
    public static int shotCount;

    // Start is called before the first frame update
    void Start()
    {
        shotCount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Shot"))
        {
            if (shotCount < 5)
            {
                Shot();
            }
        }
        
    }

    void Shot()
    {
        GameObject Tama = Instantiate(TamaPrefab, transform.position,transform.rotation);
        Rigidbody tamarigidbody = Tama.GetComponent<Rigidbody>();
        tamarigidbody.AddForce(transform.forward * shotTime);
        shotCount += 1;
    }
}
