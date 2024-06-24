using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private Image _image;
    [SerializeField] private float _changingSpeed;

    private float _target;

    public void UpdateBar(float currentHealth, float maxHealth)
    {
        _target = currentHealth / maxHealth;
    }

    private void Update()
    {
        _image.fillAmount = Mathf.MoveTowards(_image.fillAmount, _target, _changingSpeed * Time.deltaTime);
    }
}