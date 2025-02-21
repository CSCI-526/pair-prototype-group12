using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CardDisplay : MonoBehaviour
{
    public Card card;
    public TextMeshProUGUI nameText;
    public TextMeshProUGUI cardText;
    public TextMeshProUGUI priorityText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        nameText.text = card.nameText;
        cardText.text = card.cardText;
        priorityText.text = card.priority.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
