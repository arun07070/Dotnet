using Code_Challenge_4.Abstract;
using Code_Challenge_4.Concrete;
using Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Challenge_4
{
    public static class Unity
    {
        public static IUnityContainer Register()
        {
            var container = new UnityContainer();
            container.RegisterType<IDistance, DistanceClass>();
            return container;
        }
    }
}
