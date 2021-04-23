using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarUI : MonoBehaviour {

	public Slider slider;
	public Gradient gradient;
	public Image fill;

	/*	abstract public void SetMaxHealth(int maxHealth);
		*//*
		 * slider.maxValue = maxHealth;
		 * slider.value = maxHealth;
		 * fill.color = gradient.Evaluate(1f);
		 *//*

		abstract public void SetHealth(int health);
		*//*
		 *slider.value = health;
		 *fill.color = gradient.Evaluate(slider.normalizedValue);
		 */


	public void SetMaxHealth(int maxHealth) {

		slider.maxValue = maxHealth;
		slider.value = maxHealth;
		fill.color = gradient.Evaluate(1f);
	}

	public void SetHealth(int health) {

		slider.value = health;
		fill.color = gradient.Evaluate(slider.normalizedValue);
	}

}
