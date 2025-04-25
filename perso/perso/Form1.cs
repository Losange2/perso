namespace perso
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            sexecb.DropDownStyle = ComboBoxStyle.DropDownList;
            sexecb.Items.Add("Asexué");
            sexecb.Items.Add("Mâle");
            sexecb.Items.Add("Femelle");
            sexecb.SelectedIndex = 0;
            ajoutnature();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ajoutnature()
        {
            natcb.DropDownStyle = ComboBoxStyle.DropDownList;
            natcb.Items.Add("Assuré");
            natcb.Items.Add("Bizarre");
            natcb.Items.Add("Brave");
            natcb.Items.Add("Calme");
            natcb.Items.Add("Discret");
            natcb.Items.Add("Docile");
            natcb.Items.Add("Doux");
            natcb.Items.Add("Foufou");
            natcb.Items.Add("Gentil");
            natcb.Items.Add("Hardi");
            natcb.Items.Add("Jovial");
            natcb.Items.Add("Lâche");
            natcb.Items.Add("Malin");
            natcb.Items.Add("Malpoli");
            natcb.Items.Add("Mauvais");
            natcb.Items.Add("Modeste");
            natcb.Items.Add("Naïf");
            natcb.Items.Add("Pressé");
            natcb.Items.Add("Prudent");
            natcb.Items.Add("Pudique");
            natcb.Items.Add("Relax");
            natcb.Items.Add("Rigide");
            natcb.Items.Add("Sérieux");
            natcb.Items.Add("Solo");
            natcb.Items.Add("Timide");
            natcb.SelectedIndex = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
