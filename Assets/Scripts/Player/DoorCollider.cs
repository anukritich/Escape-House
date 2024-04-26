using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorCollider : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (gameObject.CompareTag("Door"))
        {
            Debug.Log("Collider Recognised");
            SceneManager.LoadScene("Room3");
        }
    }
}
