using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] int score;
    public static GameManager inst;
    [SerializeField] Text scoreText;
    [SerializeField] PlayerMove playerMovement;
    public void IncrementScore(){
        score++;
        scoreText.text="SCORE:"+score;
        playerMovement.speed+=playerMovement.speedIncreasePerPoint;
    }
    void Awake()
    {
        inst=this;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
