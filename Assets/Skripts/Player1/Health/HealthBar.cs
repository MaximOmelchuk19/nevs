using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{

    public Slider slider;
    public Gradient gradient;
    public Image fill;

    public int GetMaxHealth() {
        return (int) this.slider.maxValue;
    }

    public int GetHealth() {
        return (int) this.slider.value;
    }

    public void SetMaxHealth(int health)
    {

        slider.maxValue = health;
        
        fill.color = gradient.Evaluate(1f);
    }

   public void SetHealth(int health)
    { 
        slider.value = health; 

        fill.color = gradient.Evaluate(slider.normalizedValue); 
    }




}
