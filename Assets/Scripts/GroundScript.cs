using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundScript : MonoBehaviour
{

    public GameManager game_manager;
    public AudioClip dropSound;
    

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Ball")
        {
            SoundManager.instance.PlaySound(dropSound);
            Destroy(collision.gameObject);

        }
    }
    void Start()
    {
        
    }

    void Update()
    {

    }
}