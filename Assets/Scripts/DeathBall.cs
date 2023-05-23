using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathBall : MonoBehaviour
{
    public new ParticleSystem particleSystem;
    

    private void OnTriggerEnter2D(Collider2D collision){
        if(collision.tag == "DeathArea"){
            var myVar = Instantiate(particleSystem, transform.position, Quaternion.identity);
            Destroy(myVar,1);
        }
        
    }
}
