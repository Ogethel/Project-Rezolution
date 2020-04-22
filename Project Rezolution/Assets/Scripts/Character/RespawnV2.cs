using UnityEngine;

public class RespawnV2 : MonoBehaviour
{
    public GameObject respawnPoint;
    //public GameObject healthBar, manaBar;
    public float threshold;

    void FixedUpdate()
    {
        if (transform.position.y < threshold)
        {
            transform.position = respawnPoint.transform.position;//new Vector3(0, 50, 0);
        }
    }

    public void OnReset()
    {
        //move player back to start when "dead"
        GetComponent<CharacterController>().enabled = false;
        gameObject.transform.position = respawnPoint.transform.position;
        GetComponent<CharacterController>().enabled = true;
        //reset health and mana
        //GetComponent<HealthData>().currentHealth = GetComponent<HealthData>().definition.maxHealth;
        //GetComponent<ManaData>().currentMana = GetComponent<ManaData>().definition.maxMana;
        //update health and mana bars
        //healthBar.GetComponent<HealthBar>().OnHealthChanged();
        //manaBar.GetComponent<ManaBar>().OnManaChanged();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Respawn")
        {
            GameObject newSpawn = other.gameObject;
            ChangeRespawnPoint(newSpawn);
        }
    }

    public void ChangeRespawnPoint(GameObject newSpawn)
    {
        respawnPoint = newSpawn;
    }

}