namespace CRM
{
    public partial class F_authentification : Form
    {

        private readonly C_Authentification Authentificaion_service = new C_Authentification();

        public F_authentification()
        {
            InitializeComponent();
        }

        private void button_quitter_Click(object sender, EventArgs e)
        {
            // Ferme l'application
            Application.Exit();
        }

        private async void button_connexion_Click(object sender, EventArgs e)
        {
            try
            {
                if (radioButton_hors_ligne.Checked)
                {
                    // Mode hors ligne
                    MessageBox.Show("Connexion en mode hors ligne réussie !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // Authentification AZURE
                    var result = await Authentificaion_service.LoginAsync();

                    // Infos utilisateur disponibles
                    string userName = result.Account.Username;
                    string accessToken = result.AccessToken; // Pour appeler des APIs

                    MessageBox.Show($"Connexion réussie !\nUtilisateur : {userName}", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Vérification du token (exemple simple)
                    if (!string.IsNullOrEmpty(accessToken))
                    {
                        // Token valide, continuer vers l'application principale
                    }
                    else
                    {
                        MessageBox.Show("Token d'accès invalide.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la connexion : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
