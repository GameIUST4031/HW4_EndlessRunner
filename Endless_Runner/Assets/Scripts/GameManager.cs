using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject floorPrefab;
    public Transform Player;
    public float spawnDistance = 43.066f;
    private float lastSpawnZ;
    private Queue<GameObject> active_prefabs = new Queue<GameObject>();
    [SerializeField] List<GameObject> obstacles = new List<GameObject>();
    public int obstaclesCount = 11;
    public float obstacleDistance = 4f;
    public float minLength = 10f;
    public float maxLength = 15f;
    public float left = -4.7f;
    public float right = 4.7f;
    private float temp;
    private Queue<GameObject> obstacles_queue = new Queue<GameObject>();
    private float maxZ=0;
    private PopupMessage _popupMessage; 
    
    
    void Start()
    {
        lastSpawnZ = Player.position.z;
        Vector3 spawnPosition = new Vector3(transform.position.x, transform.position.y, lastSpawnZ);
        GameObject save = Instantiate(floorPrefab, spawnPosition, Quaternion.identity);
        active_prefabs.Enqueue(save);
        Vector3 spawnPosition2 = new Vector3(transform.position.x, transform.position.y, lastSpawnZ + spawnDistance);
        GameObject save1 = Instantiate(floorPrefab, spawnPosition2, Quaternion.identity);
        active_prefabs.Enqueue(save1);
        Vector3 spawnPosition3 = new Vector3(transform.position.x, transform.position.y,
            lastSpawnZ + spawnDistance + spawnDistance);
        GameObject save2 = Instantiate(floorPrefab, spawnPosition3, Quaternion.identity);
        active_prefabs.Enqueue(save2);
        Vector3 spawnPosition4 = new Vector3(transform.position.x, transform.position.y,
            lastSpawnZ + spawnDistance * 3);
        GameObject save3 = Instantiate(floorPrefab, spawnPosition4, Quaternion.identity);
        active_prefabs.Enqueue(save3);
        Vector3 spawnPosition5 = new Vector3(transform.position.x, transform.position.y,
            lastSpawnZ + spawnDistance * 4);
        GameObject save4 = Instantiate(floorPrefab, spawnPosition5, Quaternion.identity);
        active_prefabs.Enqueue(save4);
        lastSpawnZ += spawnDistance;
        InitiateObstacles(obstaclesCount,Player.position.z);
        _popupMessage = this.gameObject.GetComponent<PopupMessage>();
       
        // _popupMessage.Open("1.png"," salam");
    } // Update is called once per frame

    void Update()
    {
        if (Player.position.z > lastSpawnZ)
        {
            Vector3 spawnPosition = new Vector3(transform.position.x, transform.position.y,
                lastSpawnZ + spawnDistance * 4);
            GameObject save = Instantiate(floorPrefab, spawnPosition, Quaternion.identity);
            lastSpawnZ += spawnDistance;
            active_prefabs.Enqueue(save);
        }

        if (active_prefabs.Count > 5)
        {
            GameObject des = active_prefabs.Dequeue();
            Destroy(des);
        }
        DestroyObstacles();
    }

    void InitiateObstacles(int count, float zPosition)
    {
        int rand = 0;
        temp = obstacleDistance;
        float z = zPosition;
        for (int i = 0; i < count; i++)
        {
            rand = Random.Range(0, obstacles.Count);
            if (rand < 3)
            {
                GameObject obj = Instantiate(obstacles[rand],
                    new Vector3(Random.Range(left, right), 0.6f, z+temp), Player.rotation);
                obstacles_queue.Enqueue(obj);
                maxZ=obj.transform.position.z;
            }
            else
            {
                GameObject obj = 
                Instantiate(obstacles[rand],
                    new Vector3(Random.Range(left, right),1.5f, z+temp), Player.rotation);
                obstacles_queue.Enqueue(obj);
                maxZ = obj.transform.position.z;
            }
            temp+=obstacleDistance;
        }
    }

    void DestroyObstacles()
    {
        float z = Player.position.z;
        if (obstacles_queue.Peek().transform.position.z < z-10f)
        {
            Destroy(obstacles_queue.Dequeue());
            InitiateObstacles(1,maxZ);
        }
    }
}