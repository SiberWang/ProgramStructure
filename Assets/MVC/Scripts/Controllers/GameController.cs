using System.Collections.Generic;
using ForMVC.Models;
using ForMVC.Views;
using MVC.Scripts.Custom;
using UnityEngine;

namespace ForMVC.Controllers
{
    public class GameController : MonoBehaviour
    {
    #region Public Variables

        public static GameController Instance;

    #endregion

    #region Unity events

        private void Start()
        {
            SetInfos();
            gameModel.OnUpdateView += gameView.SetCard;
            gameModel.CardModel    =  GetCard();
        }

    #endregion

    #region Events

        public void OnButtonChange()
        {
            var cardModel = GetCard();
            if (cardModel.Equals(gameModel.CardModel))
            {
                OnButtonChange();
            }
            else
            {
                gameModel.CardModel = cardModel;
            }
        }

    #endregion

    #region Private Variables

        [SerializeField]
        private CardConfigOverview cardConfigOverview;

        [SerializeField]
        private GameModel gameModel;

        [SerializeField]
        private GameView gameView;

        private List<CardModel> cards = new List<CardModel>();

    #endregion

    #region Private Methods

        private void Awake()
        {
            Instance = this;
        }

        private CardModel GetCard()
        {
            var index = Random.Range(0, cards.Count);
            return cards[index];
        }

        private void SetInfos()
        {
            var cardDatas = cardConfigOverview.GetCardDatas();
            for (int i = 0; i < cardDatas.Count; i++)
            {
                var newInfo = new CardModel(cardDatas[i]);
                cards.Add(newInfo);
            }
        }

    #endregion
    }
}