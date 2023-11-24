using System;

namespace Library
{
    public class Singleton<T> where T : new()
    {
        private static T instancia;

        public static T Instancia
        {   get
            {
                if (instancia == null)
                {
                    instancia = new T();
                }
                return instancia;
            }
        }
    }
}