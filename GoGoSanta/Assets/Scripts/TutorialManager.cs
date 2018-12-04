using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TutorialManager : MonoBehaviour
{

    [SerializeField] Text tutorialMovementText;
    [SerializeField] Text tutorialShootingText;
    [SerializeField] Text tutorialScoreText;
    [SerializeField] Text tutorialSmokeText;

    // Use this for initialization
    void Start()
    {
        tutorialMovementText.enabled = true;
        tutorialShootingText.enabled = false;
        tutorialScoreText.enabled = false;
        tutorialSmokeText.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (tutorialMovementText.enabled == true)
        {
            StartCoroutine("DisplayShootingTutorial");
        }

        if (tutorialShootingText.enabled == true)
        {
            StartCoroutine("DisplayScoreTutorial");
        }

        if (tutorialScoreText.enabled == true)
        {
            StartCoroutine("DisplaySmokeTutorial");
        }

        if (tutorialSmokeText.enabled == true)
        {
            StartCoroutine("DisableSmokeTutorial");
        }
    }

    private IEnumerator DisplayShootingTutorial()
    {
        yield return new WaitForSeconds(5f);
        tutorialMovementText.enabled = false;
        tutorialShootingText.enabled = true;
    }

    private IEnumerator DisplayScoreTutorial()
    {
        yield return new WaitForSeconds(5f);
        tutorialShootingText.enabled = false;
        tutorialScoreText.enabled = true;
    }

    private IEnumerator DisplaySmokeTutorial()
    {
        yield return new WaitForSeconds(5f);
        tutorialScoreText.enabled = false;
        tutorialSmokeText.enabled = true;
    }

    private IEnumerator DisableSmokeTutorial()
    {
        yield return new WaitForSeconds(5f);
        tutorialSmokeText.enabled = false;
    }
}