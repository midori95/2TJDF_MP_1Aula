using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controles : MonoBehaviour {

    float px;
    public float velocidade;
    public float impulso;

    //Atributos
    Rigidbody2D rb2d;

	void Start () {
        rb2d = GetComponent<Rigidbody2D>();
	}
	
	void Update () {
        Mover();
        Pular();

        //Orientacao

	}

    void Mover()
    {
        //Movimento do Personagem
        px = Input.GetAxisRaw("Horizontal") * velocidade * Time.deltaTime;
        transform.Translate(px, 0.0f, 0.0f);
    }

    void Pular()
    {
        //Pulo do Personagem
        if (Input.GetButtonDown("Jump"))
        {
            rb2d.AddForce(Vector2.up * impulso);
        }
    }


}
