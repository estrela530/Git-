using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
{
    public GameObject Landmine;
    public GameObject GetParticle;
    public GameObject GetRange;
    public float DestroyTime;
    

    // Start is called before the first frame update
    void Start()
    {
        Invoke("Explode", 2);
    }

    // Update is called once per frame
    void Update()
    {
        //seconds += Time.deltaTime;
        //if (seconds >= 2)
        //{
        //    Explode();
        //}
    }

    //void ontriggerenter(gameobject other)
    //{
    //    if (other.gameobject.comparetag("player") || other.gameobject.comparetag("enemy")
    //        || other.gameobject.comparetag("tama"))
    //    {
    //        explode();
    //        destroy(other.gameobject);
    //        destroy(landmine);
    //    }
    //}

    void Explode()
    {
        var a = Instantiate(GetParticle, transform.position, transform.rotation).GetComponent<ParticleSystem>();
     
        //a.Play();
        Instantiate(GetRange, transform.position, transform.rotation);
        Destroy(Landmine);
    }

}
