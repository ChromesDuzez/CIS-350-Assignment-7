using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialScreenManager : MonoBehaviour
{
    private float originalTimeScale;

    // Start is called before the first frame update
    void Start()
    {
        originalTimeScale = Time.timeScale;
        Time.timeScale = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && GameManager.StartOfGame)
        {
            Time.timeScale = originalTimeScale;
            GameManager.StartOfGame = false;
            gameObject.SetActive(false);
        }
    }
}
