using UnityEngine;

public class CharacterTeleporter : MonoBehaviour
{
    public GameObject teleportToo;
    public float timerMove;
    public bool timerActive;
    //public CanvasGroup uiFade;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Warp")
        {
            GameObject newSpawn = other.gameObject;
            ChangeRespawnPoint(newSpawn);
        }
    }

    public void ChangeRespawnPoint(GameObject newSpawn)
    {
        timerMove = 1.5f;
        timerActive = false;
        teleportToo = newSpawn;

        gameObject.transform.position = teleportToo.transform.position;
        //FadeIn();
        GetComponent<CharacterController>().enabled = false;
        
        timerActive = true;
      
    }


    /*
    public void FadeIn()
    {
        StartCoroutine(FadeCanvasGroup(uiFade, uiFade.alpha, 1));
    }

    public void FadeOut()
    {
        StartCoroutine(FadeCanvasGroup(uiFade, uiFade.alpha, 0));
    }

    public IEnumerator FadeCanvasGroup(CanvasGroup cg, float start, float end, float lerpTime = 0.5f)
    {
        float _timeStartedLerping = Time.time;
        float timeSinceStarted = Time.time - _timeStartedLerping;
        float percentageComplete = timeSinceStarted / lerpTime;

        while (true)
        {
            _timeStartedLerping = Time.time;
            timeSinceStarted = Time.time - _timeStartedLerping;

            float currentValue = Mathf.Lerp(start, end, percentageComplete);

            cg.alpha = currentValue;

            if (percentageComplete >= 1) break;
            yield return new WaitForEndOfFrame();
        }
        print("done");
    }*/

    private void Update()
    {
        if (timerActive == true)
        {
            timerMove = timerMove - Time.deltaTime;
            if (timerMove <= 0f)
            {
                //FadeOut();
                GetComponent<CharacterController>().enabled = true;

                timerActive = false;
            }
        }
    }
}