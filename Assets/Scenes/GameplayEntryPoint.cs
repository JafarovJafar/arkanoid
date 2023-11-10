using UnityEngine;

public class GameplayEntryPoint : MonoBehaviour
{
    [SerializeField] private Level[] _levels;

    private int _currentLevel;

    private void Start()
    {
        _currentLevel = PlayerPrefs.GetInt("current_level");

        _currentLevel = Mathf.Clamp(_currentLevel, 0, _levels.Length - 1);

        var level = Instantiate(_levels[_currentLevel]);
        level.transform.position = Vector3.zero;
        level.Init();
    }
}