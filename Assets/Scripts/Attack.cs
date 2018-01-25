﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour {

    public float radius;
    public float strenght = 10;

    public int player_no = 0;

    private string player_string;

    void Start()
    {
        player_string = "P" + player_no.ToString();
        Debug.Log(player_string);
    }

    // Update is called once per frame
    void Update ()
    {

        if (Input.GetButtonDown(player_string + "B"))
        {
            Collider2D[] hitColliders = Physics2D.OverlapCircleAll(this.gameObject.transform.position, radius);

            int i = 0;
            while (i < hitColliders.Length)
            {
                if (hitColliders[i].gameObject.GetComponent<Rigidbody2D>() != null)
                {
                    if (hitColliders[i].transform.root != this.gameObject.transform)
                    {

                        Rigidbody2D rb = hitColliders[i].gameObject.GetComponent<Rigidbody2D>();
                        Vector2 opposite = this.gameObject.GetComponent<Rigidbody2D>().velocity;
                        rb.AddForce(opposite * strenght);
                        Debug.Log("Attack " + player_string);
                    }
                }
                i++;
            }
        }

    }
}