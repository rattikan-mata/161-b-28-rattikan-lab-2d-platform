using UnityEngine;
using UnityEngine.UI;

public class HealthBar : Character
{
    [SerializeField]
    private Slider sliderHp;

    [SerializeField]
    private float maxHp;

    private float currentHp;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        currentHp = maxHp;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SetHp(13);
        }
    }

    public void SetHp(float hp)
    {
        currentHp = hp;
        sliderHp.value = currentHp / maxHp;
    }
}
