using UnityEngine;
using UnityEngine.UI;

public class CurrentLvl : MonoBehaviour
{
    [SerializeField] private Text lvlText;

    private GameManager _gameManager;

    public CurrentLvl Init(GameManager gameManager)
    {
        _gameManager = gameManager;
        return this;
    }

    void Update()
    {
        lvlText.text = "Lvl " + _gameManager.lvl;
    }
}