using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnemigoPiedra : MonoBehaviour
{
    GameObject piedra;
    bool detectado;
    float velocidad = 15;
    float tiempo;
    // Start is called before the first frame update
    void Start()
    {
        piedra = GameObject.Find("Piedra");
    }

    // Update is called once per frame
    void Update()
    {
        if (detectado == true)
        {
            piedra.transform.Translate(Vector2.down * velocidad * Time.deltaTime);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Personaje")
        {
            detectado = true;
        }
    }
}
