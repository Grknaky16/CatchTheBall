using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZıplatanZemin : MonoBehaviour
{
    public float ZıplatmaKuvveti;
    public float zıplatma;

    private void OnCollisionEnter2D(Collision2D temas)
    {
        Rigidbody2D rb = temas.collider.GetComponent<Rigidbody2D>();
        if(rb != null)
        {
            Vector2 zıplamaVelocity = rb.velocity;
            zıplamaVelocity.y = ZıplatmaKuvveti;
            zıplamaVelocity.x = zıplatma;
            rb.velocity = zıplamaVelocity;
        }
    }
}
