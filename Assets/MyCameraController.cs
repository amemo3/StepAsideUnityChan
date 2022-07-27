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
        //Unity‚¿‚á‚ñ‚Æ‚ÌƒJƒƒ‰‚Ì·‚ğ‹‚ß‚é
        this.difference = Unitychan.transform.position.z - this.transform.position.z;
    }

    // Update is called once per frame
    void Update()
    {
        //Unity‚¿‚á‚ñ‚ÌˆÊ’u‚É‡‚í‚¹‚ÄƒJƒƒ‰‚ğˆÚ“®
        this.transform.position = new Vector3(0, this.transform.position.y, this.Unitychan.transform.position.z - difference);
    }
}
