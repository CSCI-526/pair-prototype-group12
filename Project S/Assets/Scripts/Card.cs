using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName="New Card", menuName="Cards")]
public class Card : ScriptableObject
{
    public string nameText;
    public string cardText;
    // public Sprite art;
    public int priority;
    // public int cooldown;
}
