using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDestroyer : MonoBehaviour
{
    GameObject Unitychan;


    void Start()
    {
        Unitychan = GameObject.Find("unitychan");
    }

    // Update is called once per frame
    void Update()
    {

        if (this.gameObject.transform.position.z+10 < this.Unitychan.transform.position.z)
        {
            Destroy(this.gameObject);
        }

    }
}
