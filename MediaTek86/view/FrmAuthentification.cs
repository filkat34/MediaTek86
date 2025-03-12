using MediaTek86.model;
using System.Windows.Forms;
using System;
using MediaTek86.controller;

namespace MediaTek86.view
{
    /// <summary>
    /// Fenêtre de connexion
    /// </summary>
    public partial class FrmAuthentification : Form
    {
        /// <summary>
        /// Contrôleur de la fenêtre
        /// </summary>
        private FrmAuthentificationController controller;


        /// <summary>
        /// Conrtuction des composants graphiques et appel des autres initialisations
        /// </summary>
        public FrmAuthentification()
        {
            InitializeComponent();
            Init();
        }

        /// <summary>
        /// Initialisations : 
        /// Création du controleur
        /// </summary>
        private void Init()
        {
            controller = new FrmAuthentificationController();
        }

        /// <summary>
        /// Demande au controleur de contrôler l'authentification
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnConnexion_Click_1(object sender, EventArgs e)
        {
            String login = TxtBoxLogin.Text;
            String pwd = TxtBoxPwd.Text;
            if (String.IsNullOrEmpty(login) || String.IsNullOrEmpty(pwd))
            {
                MessageBox.Show("Tous les champs doivent être remplis.", "Information");
            }
            else
            {
                Admin admin = new Admin(login, pwd);
                if (controller.ControleAuthentification(admin))
                {
                    TxtBoxLogin.Clear();
                    TxtBoxPwd.Clear();
                    FrmGestionPersonnel gestion = new FrmGestionPersonnel();
                    gestion.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Login ou mot de passe incorrect.", "Alerte");
                }
            }
        }
    }
}
