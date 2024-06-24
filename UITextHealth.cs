using UnityEngine;
using TMPro;

public class UITextHealth : MonoBehaviour
{
    private TextMeshProUGUI _text;

    private void Awake()
    {
        _text = GetComponent<TextMeshProUGUI>();
    }

    public void UpdateText(int currentHealth, int maxHealth)
    {
        _text.text = $"{currentHealth} / {maxHealth}";
    }
}
