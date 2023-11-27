using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContadorMonedas : MonoBehaviour
{
    public GameObject final;
    private int monedas;
    // Start is called before the first frame update
    void Start()
    {
        monedas = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (monedas == 3)
        {
            final.SetActive(true);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Monedas")
        {
            monedas++;
        }
    }
}
