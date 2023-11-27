using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;
using UnityEngine.Windows.WebCam;

public class Personaje : MonoBehaviour
{
    Rigidbody2D cuerpo;
    SpriteRenderer rojo;
    float velocidad = 3.5f;
    bool tocando;
    bool trampa;
    float tiempo;
    // Start is called before the first frame update
    void Start()
    {
        cuerpo = GetComponent<Rigidbody2D>();
        rojo = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        float movHorizontal = Input.GetAxis("Horizontal");
        
        if (trampa == true )
        {
            cuerpo.velocity = new Vector2 (0f, 0f);
            tiempo += Time.deltaTime;
            rojo.color = Color.red;

            if (tiempo > 2) 
            {
                trampa = false;
                rojo.color = Color.white;
                tiempo = 0f;
            }
        }
        else
        {
            cuerpo.velocity = new Vector2(movHorizontal * velocidad, cuerpo.velocity.y);
        }

        if (tocando == true && Input.GetButtonDown("Jump"))
        {
            cuerpo.AddForce(Vector2.up * 6, ForceMode2D.Impulse);
            tocando = false;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Suelo")
        {
            tocando = true;
        }

        if (collision.gameObject.tag == "Trampa")
        {
            trampa = true;
        }
    }
}
