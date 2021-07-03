using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDestroy : MonoBehaviour
{
    //Unityちゃんのゲームオブジェクト
    private GameObject unitychan;


    // Start is called before the first frame update
    void Start()
    {
        //Unityちゃんのオブジェクトを取得
        this.unitychan = GameObject.Find("unitychan");

    }


    // Update is called once per frame
    void Update()
    {
        //オブジェクトのz座標がunityちゃんのz座標より小さい時、オブジェクトを破棄
        if (unitychan.transform.position.z - 15 > this.gameObject.transform.position.z)
        {
            Destroy(this.gameObject);
        }
    }
}
