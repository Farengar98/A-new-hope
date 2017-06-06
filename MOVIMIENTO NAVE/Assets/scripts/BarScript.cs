using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BarScript : MonoBehaviour {
    [SerializeField]
    private float fillAmount;

    [SerializeField]
    private Image healthBarImg;
	// Use this for initialization
	void Start () {
	
	}
    private void healthBar()
    {
        healthBarImg.fillAmount = fillAmount;
    }
    // Update is called once per frame
    void Update () {
        healthBar();
	}

}
