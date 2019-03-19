using UnityEngine;
using UnityEngine.UI;

public class Scores : MonoBehaviour
{
    
    [SerializeField] private Text scoreText;
    private GameManager _gameManager;

    public Scores Init(GameManager gameManager)
    {
        _gameManager = gameManager;
        return this;
    }
    
    void Update()
    {
        scoreText.text =_gameManager.Timer.currentScores.ToString();
    }
}
