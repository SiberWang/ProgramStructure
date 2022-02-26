using System.Collections.Generic;
using ForMVC.Models;
using UnityEngine;

namespace MVC.Scripts.Custom
{
    [CreateAssetMenu(fileName = "CardConfigOverview", menuName = "CardConfigOverview", order = 0)]
    public class CardConfigOverview : ScriptableObject
    {
        [SerializeField]
        private List<CardData> cardDatas = new List<CardData>();

        public List<CardData> GetCardDatas()
        {
            return cardDatas;
        }
    }
}