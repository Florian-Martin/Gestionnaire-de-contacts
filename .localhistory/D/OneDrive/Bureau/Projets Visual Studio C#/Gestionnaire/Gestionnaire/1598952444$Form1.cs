﻿/**
 * TP 4 : Gestionnaire de contacts
 * Author : Florian MARTIN
 * Date : 30/11/2018
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestionnaire
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        // --------------------
        // VARIABLES
        // --------------------  
        List<Contact> lesContacts = new List<Contact>(); // Collection de contacts
        string fichier = "fichierSerialisation";



        // --------------------
        // METHODES
        // -------------------- 

        /** Activation / Désactivation des éléments de création de contact
         * @param bool truefalse
         * */
        private void activationChamps(bool truefalse)
        {
            txtNom.Enabled = truefalse;
            txtPrenom.Enabled = truefalse;
            txtTel.Enabled = truefalse;
            txtRechTel.Enabled = !truefalse;
            btnReset.Enabled = !truefalse;
            btnAjout.Enabled = truefalse;
            btnCancel.Enabled = truefalse;
        }

        /** Activation / Désactivation des éléments de création de contact
         * @param bool truefalse
         * */
        private void disableEditFields(bool valeur)
        {
            txtNom.Enabled = !valeur;
            txtPrenom.Enabled = !valeur;
            txtTel.Enabled = !valeur;
            txtRechTel.Enabled = valeur;
        }

        /**
         * Vidage des champs Nom / Prenom / Tel
         */
        private void vidage()
        {
            txtNom.Text = "";
            txtPrenom.Text = "";
            txtTel.Text = "";           
            pctPhoto.Image = Properties.Resources.vide;
        }




        /**
         * Ajout d'un contact à la collection si les informations requises sont bien remplies.
         * */
        private void ajoutContact()
        {
            // Test du bon remplissage des infos selon profil particulier ou pro.
            if (!txtNom.Text.Equals("") && !txtTel.Text.Equals("") && ((rdbParticulier.Checked && !txtPrenom.Text.Equals("")) || rdbPro.Checked))
            {
                // Création d'un contact profil particulier ou professionnel puis ajout dans la collection.
                if (rdbParticulier.Checked)
                {
                    lesContacts.Add(new Particulier(txtNom.Text, txtPrenom.Text, txtTel.Text, pctPhoto.Image));
                    rdbParticulier.Checked = false;
                }
                else
                {
                    lesContacts.Add(new Professionnel(txtNom.Text, txtTel.Text, pctPhoto.Image));
                    rdbPro.Checked = false;
                }
            }
            else
            {
                MessageBox.Show("Veuillez remplir toutes les informations.");
            }
             
            majListe(lesContacts.Count - 1); // MAJ de la listbox d'après la collection
            vidage();
            activationChamps(false);

            Serialise.Sauve(fichier, lesContacts); // Enregistrement des contacts
        }



        /**
         * A chaque modification de la collection de contacts on vide la listbox pour la mettre à jour.
         * */
        private void majListe(int index)
         {
            lstContacts.Items.Clear(); // Vidage de la listbox

            // Remplissage de la listbox avec la collection mise à jour
            foreach (var contact in lesContacts)
            {
                lstContacts.Items.Add(contact.infosContact());
            }


            // Sélection dans la listbox du dernier contact enregistré
            if (index != -1)
            {
                for (int i = 0; i < lstContacts.Items.Count; i++)
                {
                    if (lesContacts[index].infosContact().Equals(lstContacts.Items[i].ToString()))
                    {
                        lstContacts.SelectedIndex = i;
                    }
                }
            }
            else
            {
                lstContacts.SelectedIndex = -1;
            }
         }



         private void majListeSimple()
         {
            // Vidage de la listbox
            lstContacts.Items.Clear();

            // Remplissage de la listbox avec la collection mise à jour
            foreach (var contact in lesContacts)
            {
                lstContacts.Items.Add(contact.infosContact());
            }

            Serialise.Sauve(fichier, lesContacts);
         }


        /** Suppression d'un contact
        * @param int index : index dans la liste de contacts du contact à supprimer
        */
        private void suppr(int index)
        {
            lesContacts.Remove(lesContacts[index]);
            majListeSimple();
        }



        // --------------------
        // LISTENERS
        // -------------------- 


        /**
         * Evènement : Chargement de l'appli
         */
        private void Form1_Load(object sender, EventArgs e)
        {
            rdbParticulier.Checked = false;
            rdbPro.Checked = false;
            activationChamps(false);
            rdbParticulier.ForeColor = Color.Red;
            rdbPro.ForeColor = Color.Blue;

            // Récupération de la sauvegarde des contacts si elle existe
            Object objet = Serialise.Recup(fichier);

            if (objet != null)
            {
                lesContacts = (List<Contact>)objet;
                majListeSimple();
            }
        }

        /**
        * Evènement: clic sur le bouton ajout
        * Le contact est ajouté à la liste
        */
        private void btnAjout_Click(object sender, EventArgs e)
        {
            ajoutContact();
            rdbPro.Checked = false;
            rdbParticulier.Checked = false;
        }

        /**
         * Evènement : clic sur radiobutton Pro
         * Actualisation des composants d'ajout de contact
         */
        private void rdbPro_CheckedChanged(object sender, EventArgs e)
        {
            txtNom.Focus();

            if (rdbPro.Checked)
            {
                activationChamps(true);
                vidage();
                pctPhoto.Image = Properties.Resources.professionnel;
                pctPhoto.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            lblNom.Text = "Société :";
            txtPrenom.Enabled = false;
        }


        /**
         * Evènement: clic sur radiobutton Particulier
         * Actualisation des composants d'ajout de contact
         */
        private void rdbParticulier_CheckedChanged(object sender, EventArgs e)
        {
            txtNom.Focus();

            if (rdbParticulier.Checked)
            {
                activationChamps(true);
                vidage();
                pctPhoto.Image = Properties.Resources.particulier;
                pctPhoto.SizeMode = PictureBoxSizeMode.StretchImage;
            }

            lblNom.Text = "Nom";
        }


        /**
        * Evènement: clic sur l'image de profil
        * L'utilisateur peut changer son image de profil via la recherche dans ses dossiers personnels.
        */
        private void pctPhoto_Click(object sender, EventArgs e)
        {
                OpenFileDialog rechercheFichier;
                rechercheFichier = new System.Windows.Forms.OpenFileDialog();
                DialogResult choix = rechercheFichier.ShowDialog();

                // si un fichier est sélectionné
                if (choix == DialogResult.OK)
                {
                string nomFichier = rechercheFichier.FileName; // récupération du fichier

                    // tente d'afficher l'image
                    try
                    {
                        pctPhoto.Image = Image.FromFile(nomFichier);
                    }
                    catch (Exception ex)
                    {
                        // erreur le fichier n'est pas une image
                        MessageBox.Show("Le fichier n'est pas une image");
                        // affichage de l'image par défaut
                        pctPhoto.Image = Properties.Resources.vide;
                    }
                }
        }




        /**
         * Evènement: clic sur le bouton annuler
         */
        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Désactivation des éléments de création de contact
            activationChamps(false);

            // Vidage des champs Nom / Prenom / Tel / Déselection des radio buttons
            vidage();
            rdbPro.Checked = false;
            rdbParticulier.Checked = false;
        }


        /**
         * Evènement: clic sur le bouton modifier
         */
        private void btnModifier_Click(object sender, EventArgs e)
        {
            // Si une ligne est bien sélectionnée
            if (lstContacts.SelectedIndex != -1)
            {
                // Stockage (via index) du contact à supprimer
                int index = 0;

                // Recherche dans la collection du contact sélectionné dans la listbox
                foreach (var contact in lesContacts)
                {
                    // MAJ des champs nom, prenom, tel avec les infos du contact sélectionné
                    if (lstContacts.SelectedItem.ToString().Equals(contact.infosContact()))
                    {
                        disableEditFields(false);
                        btnCancel.Enabled = false;
                        txtPrenom.Enabled = false;
                        txtNom.Text = contact.getNom();
                        txtTel.Text = contact.getTel();

                        if (contact is Particulier)
                        {
                            txtPrenom.Enabled = true;
                            txtPrenom.Text = ((Particulier)contact).getPrenom();
                        }

                        index = lesContacts.IndexOf(contact);
                    }
                }
                // Suppression du contact puis MAJ de la listbox et activation des champs pour nouvel ajout.
                lesContacts.RemoveAt(index);
                majListeSimple();
            }
        }


        /**
         * Evènement: touche pressée dans txtRechTel
        */
        private void txtRechTel_TextChanged(object sender, EventArgs e)
        {
            // On vide la listbox et on la remplit avec uniquement les contacts contenant les caractères saisis.
            lstContacts.Items.Clear();
            int nbCarac = txtRechTel.TextLength; // Nombre de caractères du tel recherché.

            foreach (var contact in lesContacts)
            {
                try
                {
                    if (contact.getTel().Substring(0, nbCarac).Equals(txtRechTel.Text))
                    {
                        lstContacts.Items.Add(contact.infosContact());
                    }
                }
                catch{}
            }
        }


        /**
         * Evènement: clic sur le bouton "Supprimer".
         */
        private void btnSuppr_Click(object sender, EventArgs e)
        {
            int index = 0;

            // Si une ligne est bien sélectionnée
            if (lstContacts.SelectedIndex != -1)
            {
                // Recherche du contact dans la collection puis suppression
                foreach (var contact in lesContacts)
                {
                    if (lstContacts.SelectedItem.ToString().Equals(contact.infosContact()))
                    {
                        index = lesContacts.IndexOf(contact);
                    }
                }
                suppr(index); // Suppression du contact
            }
        }


        /**
         * Evènement : écriture d'une entrée dans la listbox
         * Modification de la couleur de police selon contact Particulier ou Professionnel
         */
        private void lstContacts_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index != -1)
            {
                // Colore le fond de la ligne
                e.DrawBackground();

                foreach (var contact in lesContacts)
                {
                    Color couleur;

                    if (lstContacts.Items[e.Index].ToString() == contact.infosContact())
                    {
                        // Définit la couleur du texte
                        if (contact is Particulier)
                        {
                            couleur = rdbParticulier.ForeColor;
                        }
                        else
                        {
                            couleur = rdbPro.ForeColor;
                        }

                        // écrit la ligne en utilisant la couleur définie
                        Brush myBrush = new SolidBrush(couleur);
                        e.Graphics.DrawString(lstContacts.Items[e.Index].ToString(), e.Font, myBrush, e.Bounds,StringFormat.GenericDefault);

                        // Si la listbox a le focus, dessine le rectangle qui l'entoure
                        e.DrawFocusRectangle();
                    }
                }
            }
        }


        /**
         * Evénement sélection d'un contact dans la liste
         * chargement de la photo
        */
        private void lstContacts_SelectedIndexChanged(object sender, EventArgs e)
        {
            // si une ligne est sélectionnée
            if (lstContacts.SelectedIndex != -1)
            {
                // Recherche dans la collection du contact sélectionné dans la listbox
                foreach (var contact in lesContacts)
                {
                    // MAJ des champs nom, prenom, tel avec les infos du contact sélectionné
                    if (lstContacts.SelectedItem.ToString().Equals(contact.infosContact()))
                    {
                        rdbPro.Checked = true;
                        txtPrenom.Text = "";
                        txtNom.Text = contact.getNom();
                        txtTel.Text = contact.getTel();
                        pctPhoto.Image = contact.getPhoto();

                        if (contact is Particulier)
                        {
                            rdbParticulier.Checked = true;
                            txtNom.Text = contact.getNom();
                            txtTel.Text = contact.getTel();
                            pctPhoto.Image = contact.getPhoto();
                            txtPrenom.Text = ((Particulier)contact).getPrenom();
                        }
                    }
                }
            }           
            disableEditFields(true);
        }


 


        


    }
}


