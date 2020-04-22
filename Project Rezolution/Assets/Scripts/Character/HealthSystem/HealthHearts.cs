using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HealthHearts : MonoBehaviour
{
    public float timeStart = 10f;
    public GameObject coliderObj;
    public int healthHearts;
    public int numOfHearts;

    public Image[] hearts;
    public Sprite fullHeart;
    public Sprite emptyHeart;

    public bool timerActive = false;

    public Text gameOver;

    private void Start()
    {
        gameOver.enabled = false;
    }

    private void Update()
    {
        
        if(healthHearts > numOfHearts)
        {
            healthHearts = numOfHearts;
        }
        for (int i = 0; i < hearts.Length; i++)
        {
            if(i < healthHearts)
            {
                hearts[i].sprite = fullHeart;

            }
            else
            {
                hearts[i].sprite = emptyHeart;
            }

            if (i < numOfHearts)
            {
                hearts[i].enabled = true;
            }
            else
            {
                hearts[i].enabled = false;
            }

            if(healthHearts < 1 && timerActive is true)
            {
                timeStart -= Time.deltaTime;
                if (timeStart < 0)
                {
                    EndGame();
                }
                  
            }
        }
    }
   
    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Enemy")
        {
            int newHeartTotal = healthHearts - 1;
            healthHearts = newHeartTotal;

            if (healthHearts < 1)
            {             
                timerActive = true;
                gameOver.enabled = true;
            }
        }

        if (other.gameObject.tag == "Health")
        {
            int newHeartTotal = healthHearts + 1;
            healthHearts = newHeartTotal;

            if (healthHearts > numOfHearts)
            {
                healthHearts = numOfHearts;
            }
            GameObject objectToDestroy = other.gameObject;
            Destroy(objectToDestroy);
        }

    }

    void EndGame ()
    {
        SceneManager.LoadScene("01_LockedCamera");
    }

}
