using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{

    //singleton
    public static UIManager UIM;
    //score text
    public TMP_Text score;

    void Awake()
    {
        UIM = this;
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void updateScore(int newScore){
        score.text = "Score: " + newScore;
    }
}
