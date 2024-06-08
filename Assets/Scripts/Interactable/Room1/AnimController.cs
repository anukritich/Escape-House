using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AnimController : MonoBehaviour
{
    [SerializeField]
    public Animator animator = null;
    public TMP_Text messageText;
  

    void Start()
    {
        animator = GetComponent<Animator>();
    }


    void Update()
    {

        if (Voilet.check == true && Blue.check == true && Indigo.check == true &&
            Green.check == true && Yellow.check == true
            && Orange.check == true && Red.check == true)
        {
            
            //animator.Play("DoorOpen", 0, 0.0f);
            animator.SetTrigger("doorOpen");
            Debug.Log("Animation playing");
            messageText.text = "The door is unlocked";
            StartCoroutine(LoadNextSceneAfterDelay(2.0f));
        }
    }
    private IEnumerator LoadNextSceneAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);
        SceneManager.LoadScene("Room 2");
    }
}
