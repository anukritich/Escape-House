// KeyPad Script
using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KeyPad : MonoBehaviour
{
    public Animator animator;
    public TMP_Text messageText;
    public TextMeshProUGUI CodeText;
    private string codetextvalue = "";
    public string SafeCode;
    public GameObject CodePanel;
    public bool passcheck = false;

    private void Start()
    {
        CodePanel.SetActive(false);
        animator = GetComponent<Animator>();
    }

    public void HandleKeypadInput()
    {
        KeycodeEnter();
        Debug.Log("door");
    }

    private void KeycodeEnter()
    {
        CodeText.text = codetextvalue;
        if (codetextvalue == SafeCode)
        {
            UnlockDoor();
        }
        else if (codetextvalue.Length >= 4)
        {
            codetextvalue = "";
        }
        else  if (Input.GetMouseButtonDown(0))
            {
            CodePanel.SetActive(true);
        }
    }

    private void UnlockDoor()
    {
        passcheck = true;
        animator.SetTrigger("open");
        CodePanel.SetActive(false);
        Debug.Log("Animation playing");
        messageText.text = "The door is unlocked";
        StartCoroutine(LoadNextSceneAfterDelay(2.0f));
    }

    public void AddDigit(string digit)
    {
        codetextvalue += digit;
    }

    private IEnumerator LoadNextSceneAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);
        SceneManager.LoadScene("Start");
    }
}
