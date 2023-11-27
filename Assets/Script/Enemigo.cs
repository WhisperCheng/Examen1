using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour
{
    public float velocidad;
    bool direccion;
    public float distanciaDerecha;
    public float distanciaIzquierda;
    bool dañado;

    // Start is called before the first frame update
    void Start()
    {
        velocidad = 5;
        distanciaDerecha = 5;
        distanciaIzquierda = -10;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > distanciaDerecha)
        {
            direccion = false;
        }
        else if (transform.position.x < distanciaIzquierda)
        {
            direccion = true;
        }
        if (direccion == true)
        {
            transform.Translate(Vector2.right * velocidad * Time.deltaTime);
        }
        else if (direccion == false)
        {
            transform.Translate(Vector2.left * velocidad * Time.deltaTime);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Personaje")
        {
            Time.timeScale = 0f;
        }
    }
}
