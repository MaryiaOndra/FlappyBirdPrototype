using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    [SerializeField] private Bird _bird;
    [SerializeField] private TMP_Text _score;

    private void OnEnable()
    {
        _bird.ScoreChanged += OnScoreChange;
    }
    private void OnDisable()
    {
        _bird.ScoreChanged -= OnScoreChange;
    }

    private void OnScoreChange() 
    {
        _score.text = _bird.Score.ToString();
    }
}
