using UnityEngine;

namespace ForMVC.Models
{
    public class GameModel : MonoBehaviour
    {
        public delegate void IUpdateView(CardModel cardModel);

        public event IUpdateView OnUpdateView;

        private CardModel cardModel;

        public CardModel CardModel
        {
            get => cardModel;
            set
            {
                cardModel = value;
                OnUpdateView?.Invoke(cardModel);
            }
        }
    }
}