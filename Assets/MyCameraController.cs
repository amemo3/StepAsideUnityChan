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
        //Unity�����Ƃ̃J�����̍������߂�
        this.difference = Unitychan.transform.position.z - this.transform.position.z;
    }

    // Update is called once per frame
    void Update()
    {
        //Unity�����̈ʒu�ɍ��킹�ăJ�������ړ�
        this.transform.position = new Vector3(0, this.transform.position.y, this.Unitychan.transform.position.z - difference);
    }
}
