using UnityEngine;

public class smallFood : MonoBehaviour
{

    private int value = 10;
    private int health = 10;
    private Transform food;

   

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
        //increase points
        
        //remove from list!
        GameManager.GM.removeFood(this.gameObject);

        //destroy self
        Destroy(this.gameObject);

    }
}

