using System;
using UnityEngine;

namespace ForMVC.Models
{
    public struct CardModel
    {
        public string CardName;
        public Sprite Sprite;
        public int    Attack;
        public int    Defense;
        public int    Heart;

        public CardModel(string cardName, Sprite sprite, int attack, int defense, int heart)
        {
            CardName = cardName;
            Sprite   = sprite;
            Attack   = attack;
            Defense  = defense;
            Heart    = heart;
        }

        public CardModel(CardData cardData)
        {
            CardName = cardData.CardName;
            Sprite   = cardData.Sprite;
            Attack   = cardData.Attack;
            Defense  = cardData.Defense;
            Heart    = cardData.Heart;
        }
    }

    [Serializable]
    public class CardData
    {
        public string CardName;
        public Sprite Sprite;
        public int    Attack;
        public int    Defense;
        public int    Heart;
    }
}