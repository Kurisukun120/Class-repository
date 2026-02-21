using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject pigPrefab;
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
            spawnPig();
            spawnerTimer = 0.0f;
        }
    }

    private void spawnPig()
    {
        int randomPosIndx = Random.Range(0, posRefArray.Length);
        Instantiate(pigPrefab, posRefArray[randomPosIndx].position, Quaternion.identity);
    }
}
