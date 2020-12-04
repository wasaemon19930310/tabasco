using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TabascoGenerator : MonoBehaviour
{
    public GameObject tabascoPrefab;
    private float span;
    private float delta;
    private Vector3[] positions;
    private Entity entity;

    void Start()
    {
        this.entity = GameObject.Find("Entity").GetComponent<Entity>();
        this.span = 2.5f;
        this.delta = 0f;
        this.entity.GeneratorIndex = 0;
        // 上下の座標
        this.positions = new Vector3[3];
        this.positions[0] = new Vector3(10f, 2.3f, 0f);
        this.positions[1] = new Vector3(10f, -2.3f, 0f);
    }
    void Update()
    {
        // 0から1の番号を取得する
        this.entity.GeneratorIndex = Random.Range(0, 2);
        this.delta += Time.deltaTime;
        if(this.span < this.delta)
        {
            this.delta = 0;
            // タバスコを生成する
            GameObject tabasco = Instantiate(tabascoPrefab) as GameObject;
            tabasco.transform.position = this.positions[this.entity.GeneratorIndex];
            tabasco.transform.SetParent(this.gameObject.transform, false);
        }
    }
}
