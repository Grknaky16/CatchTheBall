using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PotaRotator : MonoBehaviour
{
    public float rotationSpeed =5f;
    public float rotationSpeedAndroid = 5f;
    public GameManager game_manager;
    public GameObject next_level;
    public new ParticleSystem particleSystem;
    public int Puan=0;
    

    public AudioClip scoreSound;
    
    public int catchtheball;
    public int tutucu=0;
    

    public void OnTriggerEnter2D(Collider2D collision){
        
        if(collision.tag == "Ball"){
            
            catchtheball -= 1;
            tutucu +=1;
            Puan = PlayerPrefs.GetInt("Puan");
            Puan=Puan+1;
            PlayerPrefs.SetInt("Puan", Puan);
            var myVar = Instantiate(particleSystem, transform.position, Quaternion.identity);
            Destroy(collision.gameObject); // Topu silme
            Destroy(myVar,1);
            SoundManager.instance.PlaySound(scoreSound);
            
            if(catchtheball == 0)
            {
                game_manager.StopSpawning();
                Time.timeScale = 0;
                next_level.SetActive(true);
                PlayerPrefs.SetInt("catchtheball", tutucu);
                tutucu = 0;
            }
        }
        
    }

    private void Update(){
        #if UNITY_EDITOR
            if(Input.GetMouseButton(0)){
                
                float mouseX = Input.GetAxis("Mouse X");
                transform.Translate(mouseX * rotationSpeed * Time.deltaTime,0 ,0);
                Vector3 pos=transform.position;
                pos.x = Mathf.Clamp(pos.x,-2.31f,2.31f);
                transform.position=pos;

            }
        #elif UNITY_Android
            if(Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved){
                float xDeltaPos= Input.GetTouch(0).deltaPosition.x;
                transform.Translate(xDeltaPos * rotationSpeedAndroid * Time.deltaTime,0 , 0);
                Vector3 pos=transform.position;
                pos.x = Mathf.Clamp(pos.x,-2.31f,2.31f);
                transform.position=pos;
            }
        #endif
    }
}
