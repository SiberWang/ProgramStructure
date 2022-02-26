using System;
using ForMVC.NotUse.Models;
using ForMVC.NotUse.Views;

namespace ForMVC.NotUse.Controllers
{
    public abstract class Controller
    {
        public abstract void Execute(object data);

        protected T GetModel<T>() where T : Model
        {
            return MVC.GetModel<T>();
        }

        protected T GetView<T>() where T : View
        {
            return MVC.GetView<T>();
        }

        protected void RegisterModel(Model model)
        {
            MVC.RegisterModel(model);
        }

        protected void RegisterView(View view)
        {
            MVC.RegisterView(view);
        }

        protected void RegisterController(string eventName, Type controllerType)
        {
            MVC.RegisterController(eventName, controllerType);
        }
    }
}