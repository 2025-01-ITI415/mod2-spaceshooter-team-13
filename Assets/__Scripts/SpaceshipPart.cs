using UnityEngine;

public class SpaceshipPart : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("SpaceshipPart triggered by: " + other.name); 

        Hero hero = other.GetComponent<Hero>();
        if (hero != null)
        {
            Debug.Log("Spaceship part collected by Hero."); 
            hero.CollectPart();
            Destroy(this.gameObject);
        }
    }
}