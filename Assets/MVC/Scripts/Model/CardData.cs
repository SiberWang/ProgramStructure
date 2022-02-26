using UnityEngine;
using UnityEngine.UI;

namespace MVC.Scripts.Model
{
    [CreateAssetMenu(fileName = "CardData", menuName = "MVC/CardData", order = 0)]
    public class CardData : ScriptableObject
    {
        public string CardName;
        public Image  Image;
        public int    Attack;
        public int    Defense;
        public int    Heart;
    }
}