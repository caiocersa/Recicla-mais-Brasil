﻿using System;
using System.Web;

namespace ReciclaMaisBrasil.Util
{
    public enum SessionKeys {PESSOA, INSTITUICAO} //aqui coloca-se o tipo do usuário: pessoa, usuário ou instituição

    public static class SessionHelper
    {
        public static object Get(SessionKeys chave)
        {
            string chaveString = Enum.GetName(typeof(SessionKeys), chave);
            return HttpContext.Current.Session[chaveString];
        }

        public static object Set(SessionKeys chave, object valor)
        {
            string chaveString = Enum.GetName(typeof(SessionKeys), chave);
            return HttpContext.Current.Session[chaveString] = valor;
        }
    }

 
}