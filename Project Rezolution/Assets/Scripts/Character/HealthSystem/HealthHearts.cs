using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HealthHearts : MonoBehaviour
{
    public float timeStart = 10f;
    public GameObject coliderObj;
    public int healthHearts;
    public int numOfHearts;

    public GameObject endGame;
    public Image[] hearts;
    public Sprite fullHeart;
    public Sprite emptyHeart;

    public float canBeHurt=1f;

    public bool timerActive = false;

    public Text gameOver;

    private void Start()
    {
        gameOver.enabled = false;
        endGame.SetActive(false);
    }

    private void Update()
    {
        canBeHurt = canBeHurt - Time.deltaTime;
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

        if (other.gameObject.tag == "Enemy" && canBeHurt <= 0f)
        {
            int newHeartTotal = healthHearts - 1;
            healthHearts = newHeartTotal;

            if (healthHearts < 1)
            {             
                timerActive = true;
                gameOver.enabled = true;
            }
            canBeHurt = 1f;
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

        if (other.gameObject.tag == "HealthUpgrade" && canBeHurt <= 0f)
        {
            int newHeartTotal = numOfHearts + 1;
            numOfHearts = newHeartTotal;

            int currentHearts = numOfHearts;
            healthHearts = currentHearts;

            canBeHurt = 1f;
        }
    }

    void EndGame ()
    {
        endGame.SetActive(true);
        //SceneManager.LoadScene("01_LockedCamera");
    }

}
