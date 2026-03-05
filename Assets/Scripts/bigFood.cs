using UnityEngine;

public class bigFood : MonoBehaviour
{

    private int value = 0;
    private int health = 10;
    private Transform food;

   public GameObject mediumFoodPrefab;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
         food = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void takeDamage(int damage)
    {
        health -= damage;
        if(health <= 0)
        {
            die();
        }
    }

    private void die()
    {
        //spawn 2 medium foods
        Vector3 foodPosition = new Vector3 (food.transform.position.x - 0.5f, food.transform.position.y, food.transform.position.z);
        Instantiate(mediumFoodPrefab, foodPosition, transform.rotation);
        foodPosition = new Vector3 (food.transform.position.x + 0.5f, food.transform.position.y, food.transform.position.z);
        Instantiate(mediumFoodPrefab, food.transform.position, transform.rotation);
        
        //remove from list!
        GameManager.GM.removeFood(this.gameObject);

        //destroy self
        Destroy(this.gameObject);

    }
}
