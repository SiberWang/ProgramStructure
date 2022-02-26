using System;
using System.Collections.Generic;
using ForMVC.NotUse.Controllers;
using ForMVC.NotUse.Models;
using ForMVC.NotUse.Views;

namespace ForMVC.NotUse
{
    public class MVC
    {
        public static Dictionary<string, Model> Models    = new Dictionary<string, Model>();
        public static Dictionary<string, View>  Views     = new Dictionary<string, View>();
        public static Dictionary<string, Type>  ComandMap = new Dictionary<string, Type>();

        public static void RegisterView(View view)
        {
            if (Views.ContainsKey(view.Name))
            {
                Views.Remove(view.Name);
            }

            view.RegisterAttentionEvent();
            Views[view.Name] = view;
        }

        public static void RegisterModel(Model model)
        {
            Models[model.Name] = model;
        }

        public static void RegisterController(string eventName, Type controllerTpye)
        {
            ComandMap[eventName] = controllerTpye;
        }

        public static T GetModel<T>() where T : Model
        {
            foreach (var model in Models.Values)
            {
                if (model is T)
                    return (T) model;
            }

            return null;
        }

        public static T GetView<T>() where T : View
        {
            foreach (var view in Views.Values)
            {
                if (view is T)
                    return (T) view;
            }

            return null;
        }

        public static void SendEvent(string eventName, object data)
        {
            if (ComandMap.ContainsKey(eventName))
            {
                Type       t = ComandMap[eventName];
                Controller c = Activator.CreateInstance(t) as Controller;
                c.Execute(data);
            }

            foreach (var value in Views.Values)
            {
                if (value.AttentionList.Contains(eventName))
                {
                    value.HandleEvnet(eventName, data);
                }
            }
        }
    }
}