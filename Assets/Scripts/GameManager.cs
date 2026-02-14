using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject woodPrefab;
    private float spawnerTimer = 0.0f;
    public float rateofSpawn = 1.0f;
    public Transform[] posRefArray;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        spawnerTimer += Time.deltaTime;

        if( spawnerTimer >= rateofSpawn)
        {
            SpawnWood();
            spawnerTimer = 0.0f;
        }
    }

    private void SpawnWood()
    {
        int randomPosIndx = Random.Range(0, posRefArray.Length);
        Instantiate(woodPrefab, posRefArray[randomPosIndx].position, Quaternion.identity);
    }
}
