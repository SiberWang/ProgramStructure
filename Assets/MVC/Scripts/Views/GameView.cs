using ForMVC.Controllers;
using ForMVC.Models;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace ForMVC.Views
{
    public class GameView : MonoBehaviour
    {
        public TextMeshProUGUI TMPTextName;
        public Image           Image;
        public TextMeshProUGUI TMPTextAttack;
        public TextMeshProUGUI TMPTextDefense;
        public TextMeshProUGUI TMPTextHeart;

        public Button MainButton;

        private void Start()
        {
            if (MainButton != null)
            {
                UnityAction onClickButton = GameController.Instance.OnButtonChange;
                MainButton.onClick.AddListener(onClickButton);
            }
        }

        // 被呼叫的Event
        public void SetCard(CardModel model)
        {
            TMPTextName.text    = $"名稱: {model.CardName}";
            Image.sprite        = model.Sprite;
            TMPTextAttack.text  = $"攻擊力: {model.Attack.ToString()}";
            TMPTextDefense.text = $"防禦力: {model.Defense.ToString()}";
            TMPTextHeart.text   = $"生命值: {model.Heart.ToString()}";
        }
    }
}