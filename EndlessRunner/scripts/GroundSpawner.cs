using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundSpawner : MonoBehaviour
{
    [SerializeField] GameObject GroundTile;
    Vector3 nextspawnpoint;
    // Start is called before the first frame update
    public void SpawnTile(bool spawnItems){
        GameObject temp=Instantiate(GroundTile,nextspawnpoint,Quaternion.identity);
        nextspawnpoint=temp.transform.GetChild(1).transform.position;

        if(spawnItems){
            temp.GetComponent<GroundTIle>().ObstacleSpawn();
            temp.GetComponent<GroundTIle>().SpawnCoins();
        }
    }
    void Start()
    {
        for(int i=0;i<15;i++){
            if(i<3){
                SpawnTile(false);
            }
            else{
            SpawnTile(true);
            }
        }
    }

}
