using System;
using System.Collections.Generic;
using System.Text;

namespace reseau_sociaux
{
    public static class UserSession
    {     // stoke les informations de l'utilisateur connecte
        public static Etudiant CurrentUser { get; set; }
         
        //vide le conteneur a la deconnexion

        public static void LogOut() 
        {
            CurrentUser = null;
        }
    }
}
