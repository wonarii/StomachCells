using UnityEngine;

public class foodMovement : MonoBehaviour
{
    private Transform food;
    public float foodSpeedY;
    private float speedX;
    public float minSpeedX;
    public float maxSpeedX;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        food = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        moveFood();
    }


    void moveFood()
    {
        
        //move down
        if(food.transform.position.y > -3.53)
        {
            food.transform.position = new Vector3(food.transform.position.x, food.transform.position.y - foodSpeedY, food.transform.position.z);
            
        }

        //move sideways
        //(irregular)
        if(food.transform.position.y < 2.36)
        {
            
            //randomized
            int direction = UnityEngine.Random.Range(0,1);
            //randomized speed
            speedX = Random.Range(minSpeedX,maxSpeedX);
            if(direction == 0)
            {
                //staying in bounds!
                if(food.transform.position.x > -3.48){
                //move left
                food.transform.position = new Vector3(food.transform.position.x - speedX, food.transform.position.y, food.transform.position.z);
                
                }

            }
            else
            {
                if(food.transform.position.x < 1.25){
                //move right
                food.transform.position = new Vector3(food.transform.position.x - speedX, food.transform.position.y, food.transform.position.z);
                }
            }
        }

    }
}
