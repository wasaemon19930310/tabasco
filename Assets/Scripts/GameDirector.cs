using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameDirector : MonoBehaviour
{
    private GameObject hpGauge;
    void Start()
    {
        this.hpGauge = GameObject.Find("HPGauge");
        this.hpGauge.GetComponent<Slider>().value = 3;
    }
    /**
     * HPを減らす。
     */
    public void DecreaseHpGauge()
    {
        this.hpGauge.GetComponent<Slider>().value -= 1;
        if(this.hpGauge.GetComponent<Slider>().value <= 0)
        {
            SceneManager.LoadScene("GameScene");
        }
    }
}
