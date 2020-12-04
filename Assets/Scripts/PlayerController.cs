using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    void Start()
    {

    }
    void Update()
    {
        // スペースキーが押された場合
        if(Input.GetMouseButtonDown(0) && this.gameObject.GetComponent<Rigidbody2D>().velocity.y == 0)
        {
            // ジャンプする
            this.gameObject.GetComponent<Rigidbody2D>().AddForce(transform.up * 1200.0f);
        }
    }
    /**
     * 当たり判定の処理
     */
    void OnTriggerEnter2D(Collider2D other)
    {
        // HPを減らす
        GameObject.Find("GameDirector").GetComponent<GameDirector>().DecreaseHpGauge();
        // タバスコを消す
        Destroy(other.gameObject);
    }
}
