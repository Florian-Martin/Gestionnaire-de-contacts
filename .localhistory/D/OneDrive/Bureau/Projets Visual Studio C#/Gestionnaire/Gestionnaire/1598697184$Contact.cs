using System;
using System.Drawing;

namespace Gestionnaire
{
    /**
     * Classe abstraite Contact
     * nom, tel et photo du contact
     */
    [SerializableAttribute]
    public abstract class Contact
    {
        private string nom;
        private string tel;


        public Contact(string nom, string tel)
        {
            this.nom = nom;
            this.tel = tel;
        }
        public string getNom()
        {
            return this.nom;
        }
        public string getTel()
        {
            return this.tel;
        }
        public abstract string infosContact();
    }

    /**
     * Classe Particulier, hérite de Contact
     * Ajoute le prénom
     */
    [SerializableAttribute]
    public class Particulier : Contact
    {
        private string prenom;
        public Particulier(string nom, string prenom, string tel) : base(nom, tel)
        {
            this.prenom = prenom;
        }
        public string getPrenom()
        {
            return this.prenom;
        }
        public override string infosContact()
        {
            return getNom() + " " + getPrenom() + " (" + getTel() + ")";
        }
    }

    /**
     * Classe Professionnel, hérite de Contact
     */
    [SerializableAttribute]
    public class Professionnel : Contact
    {
        public Professionnel(string nom, string tel) : base(nom, tel) { }
        public override string infosContact()
        {
            return getNom() + " (" + getTel() + ")";
        }
    }

}
