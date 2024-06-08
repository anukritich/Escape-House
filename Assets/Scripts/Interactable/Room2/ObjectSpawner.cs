using System.Collections;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    public GameObject[] objectsToSpawn;
    public float spawnInterval = 1.0f;

    private int currentIndex = 0;

    private void Start()
    {
        StartCoroutine(SpawnObjects());
    }

    private IEnumerator SpawnObjects()

    {
        Debug.Log("Spawn object");
        while (currentIndex < objectsToSpawn.Length)
        {
            Instantiate(objectsToSpawn[currentIndex], transform.position, transform.rotation);
            currentIndex++;
            yield return new WaitForSeconds(spawnInterval);
        }
    }

    private void OnDrawGizmosSelected()
    {
        // Draw a wireframe sphere at the spawn position to visualize the spawn area
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, 0.5f);
    }
}
