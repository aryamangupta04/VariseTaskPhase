using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstacle : MonoBehaviour
{
    PlayerMove playerMove;
    // Start is called before the first frame update
    void Start()
    {
        playerMove=GameObject.FindObjectOfType<PlayerMove>();
    }
private void OnCollisionEnter(Collision other)
{
    if(other.gameObject.name == "player"){
    playerMove.Die();
    }
}
    // Update is called once per frame
    void Update()
    {
        
    }
}
