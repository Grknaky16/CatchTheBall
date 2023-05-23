using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CountDown : MonoBehaviour
{
    public GameManager game_manager;
    public GameObject gameOver;
    [SerializeField] private Image _timerImg;
    [SerializeField] private Text _timerText;
   

    private float _currentTime;

    [SerializeField] private float _duration;
    
    void Start()
    {
        _currentTime = _duration;
        _timerText.text = _currentTime.ToString();
        StartCoroutine(UpdateTime());
    }
 
    private IEnumerator UpdateTime(){
        while(_currentTime >= 0 ){
            _timerImg.fillAmount = Mathf.InverseLerp(0,_duration,_currentTime);
            _timerText.text = _currentTime.ToString();
            yield return new WaitForSeconds(1f);
            _currentTime--;
            
        }
        yield return null;
    }
    void Update(){
        if(_currentTime == 0){
                game_manager.StopSpawning();
                Time.timeScale = 0;
                gameOver.SetActive(true);
            }
    }
    
}
