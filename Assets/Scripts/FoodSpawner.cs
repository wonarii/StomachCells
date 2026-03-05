using UnityEngine;
using System.Collections;

public class FoodSpawner : MonoBehaviour
{

    private float timeUntilNextSpawn;
    public float maxTimeUntilNextSpawn;
    public float minTimeUntilNextSpawn;
    public GameObject bigFoodPrefab;
    public GameObject mediumFoodPrefab;
    public GameObject smallFoodPrefab;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(SpawnFood());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private IEnumerator SpawnFood()
    {
        //spawn location (always same spot)
        float x = -3.6f;
        float y = 4f;
        Vector3 foodPosition = new Vector3(x, y, 0);
        
        //choose what size food to spawn
        //CURRENTLY SET TO ONLY SMALL FOODS
        // int foodSize = UnityEngine.Random.Range(10,11);

         // GameObject currentFood;

        // switch (foodSize)
        // {
        //     case 1:
        //         {
        //             currentFood = Instantiate(bigFoodPrefab, foodPosition, transform.rotation);
        //             break;
        //         }
        //     case 2:
        //         {
        //            currentFood = Instantiate(mediumFoodPrefab, foodPosition, transform.rotation);
        //             break;
        //         }
        //     case 3:
        //         {
        //             currentFood = Instantiate(mediumFoodPrefab, foodPosition, transform.rotation);
        //             break;
        //         }
        //     default:
        //         {
                   GameObject currentFood = Instantiate(smallFoodPrefab, foodPosition, transform.rotation);
        //           break; 
        //         }
        // }
  
        //add the food to the game manager's array
        //GameManager.GM.addFood(currentFood);

        timeUntilNextSpawn = Random.Range(minTimeUntilNextSpawn,maxTimeUntilNextSpawn);

    //wait before spawning the next food
    yield return new WaitForSeconds(timeUntilNextSpawn);
    StartCoroutine(SpawnFood());
    }
}
