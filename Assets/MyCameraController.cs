using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyCameraController : MonoBehaviour
{
    private GameObject Unitychan;
    private float difference;
    void Start()
    {
        this.Unitychan=GameObject.Find("unitychan");
        //Unityちゃんとのカメラの差を求める
        this.difference = Unitychan.transform.position.z - this.transform.position.z;
    }

    // Update is called once per frame
    void Update()
    {
        //Unityちゃんの位置に合わせてカメラを移動
        this.transform.position = new Vector3(0, this.transform.position.y, this.Unitychan.transform.position.z - difference);
    }
}
