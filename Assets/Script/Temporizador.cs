using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class Tiempo : MonoBehaviour
{
    public TMP_Text tiempo;
    public float segundos;
    // Start is called before the first frame update
    void Start()
    {
        segundos = 60f;
        tiempo.text = "Tiempo = 60";
    }

    // Update is called once per frame
    void Update()
    {
        segundos -= Time.deltaTime;
        tiempo.text = "Tiempo = " + segundos.ToString("F2");

        if (segundos <= 0)
        {
            Time.timeScale = 0;
        }
    }
}
