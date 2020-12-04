using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TabascoController : MonoBehaviour
{
    private Entity entity;

    void Start()
    {
        this.entity = GameObject.Find("Entity").GetComponent<Entity>();
    }
    void Update()
    {
        // 画面の外に出た場合
        if(this.gameObject.transform.position.x < -10f)
        {
            // 0から1の番号を取得する
            this.entity.ControllerIndex = Random.Range(0, 2);
            // 削除する
            Destroy(this.gameObject);
        }
        // 右に移動させながら回転させる
        Vector3 currentPosition = this.gameObject.transform.position;
        if(this.entity.ControllerIndex == 0)
        {
            currentPosition.x -= 0.1f;
        }
        else if(this.entity.ControllerIndex == 1)
        {
            currentPosition.x -= 0.2f;
        }
        this.gameObject.transform.position = currentPosition;
        this.gameObject.transform.RotateAround(
            currentPosition
            , new Vector3(0f, 0f, (float) this.entity.ControllerIndex)
            , 200 * Time.deltaTime
        );
    }
}
