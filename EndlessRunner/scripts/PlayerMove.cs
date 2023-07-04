
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMove : MonoBehaviour
{
    public float speed=5f;
    float horizontalInput;
    [SerializeField] Rigidbody rb;
    bool alive=true;
    public float speedIncreasePerPoint=0.1f;
    private void FixedUpdate(){
        if(alive!=true)return;
        Vector3 forwardMove= transform.forward*speed*Time.fixedDeltaTime;
        Vector3 HorizontalMove=transform.right*horizontalInput*speed*Time.fixedDeltaTime;
        rb.MovePosition(rb.position+forwardMove+HorizontalMove);
    }

    private void Update() {
        horizontalInput=Input.GetAxis("Horizontal");
        if(transform.position.y<-5){
            Die();
        }
    }
    public void Die(){
        alive=false;
       Invoke("Restart",1);

    }
    void Restart(){
         SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}


