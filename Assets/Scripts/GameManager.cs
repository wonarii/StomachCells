using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class GameManager : MonoBehaviour
{

    //singleton
    public static GameManager GM;

    //score
    private int score;

    //keeping track of hydrochloric amount
    private int hydrochloricAcidCount;

    //array of all the food prefabs on scene
    private List<GameObject> food;

    public float digestionTime;

    void Awake()
    {
        GM = this;
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        reset();
        StartCoroutine(digest());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void reset()
    {
        score = 0;
        hydrochloricAcidCount = 0;
        food = new List<GameObject>();
    }

    private IEnumerator digest()
    {
        for(int i =0; i < food.Count; i++)
        {
            food[i].bigFood.takeDamage(hydrochloricAcidCount);
        }
         yield return new WaitForSeconds(digestionTime);
        StartCoroutine(digest());
    }
//add food to the array list
    public void addFood(GameObject foodToAdd)
    {
        food.Add(foodToAdd);
    }

    //remove food from array list
    public void removeFood(GameObject foodToRemove)
    {
        food.Remove(foodToRemove);
    }
}
