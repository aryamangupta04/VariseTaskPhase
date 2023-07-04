using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundTIle : MonoBehaviour
{
    GroundSpawner groundSpawner;
     [SerializeField] GameObject CoinPrefab;
      [SerializeField] GameObject ObstaclePrefab;

    // Start is called before the first frame update
    void Start()
    {
        groundSpawner=GameObject.FindObjectOfType<GroundSpawner>();
        
    }
    void OnTriggerExit(Collider other)
    {
      groundSpawner.SpawnTile(true);  
      Destroy(gameObject, 2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   
    public void ObstacleSpawn(){
        int index=Random.Range(2,5);
        Transform spawnPoint=transform.GetChild(index).transform;
        Instantiate(ObstaclePrefab,spawnPoint.position,Quaternion.identity,transform);
    }
   
    public void SpawnCoins(){
        int coinsToSpawn=2;
        for (int i = 0; i < coinsToSpawn; i++)
        {
           GameObject temp= Instantiate(CoinPrefab,transform);
           temp.transform.position=GetRandomPointInCollider(GetComponent<Collider>());
        }
    }
    Vector3 GetRandomPointInCollider(Collider collider){
        Vector3 point=new Vector3(
            Random.Range(collider.bounds.min.x,collider.bounds.max.x),
             Random.Range(collider.bounds.min.y,collider.bounds.max.y),
              Random.Range(collider.bounds.min.z,collider.bounds.max.z)
            );
            point.y=1;
            return point;
    }

}
