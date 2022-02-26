using System.Collections.Generic;
using ForMVC.NotUse.Models;
using UnityEngine;

namespace ForMVC.NotUse.Views
{
    public abstract class View : MonoBehaviour
    {
        public abstract string Name { get; }

        [HideInInspector]
        public List<string> AttentionList = new List<string>();

        public virtual void RegisterAttentionEvent() { }

        public abstract void HandleEvnet(string name, object data);

        protected void SendEvent(string eventName, object data = null)
        {
            MVC.SendEvent(eventName, data);
        }

        protected T GetModel<T>() where T : Model
        {
            return MVC.GetModel<T>();
        }
    }
}