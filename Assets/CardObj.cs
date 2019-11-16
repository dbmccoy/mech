using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardObj : MonoBehaviour
{
    public Card card;

    public Text nameText;
    public Text descriptionText;

    public Image artImage;
    public Text costText;

    // Start is called before the first frame update
    void Start()
    {
        nameText.text = card.name;
        descriptionText.text = card.description;

        artImage.sprite = card.artwork;
        costText.text = card.cost.ToString();
    }

    public void Hover()
    {

    }

    public void Play()
    {

    }
}
