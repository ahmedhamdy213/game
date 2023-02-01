using UnityEngine;

public class respawn : MonoBehaviour{

    public Transform player;
    public Vector3 offset;

    public Transform[]  spawnPoints;
    public GameObject block;
    public float hi = 1f;
    private float B = 2f;
    void Update()
    {
        if (Time.time >= B)
        {
            SpawnBlocks();
            B = Time.time + hi;

        }
        transform.position = player.position + offset;
    }
    void SpawnBlocks()
    {
        int randomIndex = Random.Range(0, spawnPoints.Length);
        for (int i = 0; i < spawnPoints.Length; i++)
        {
            if (randomIndex != i)
            {
                Instantiate(block, spawnPoints[i].position, Quaternion.identity);

            }
        }
    }
    


}
