namespace pryTeatro
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        private void btnQuena_Click(object sender, EventArgs e)
        {
            Form teatro = new frmQuenaken();
            teatro.ShowDialog();
        }

        private void btnOnas_Click(object sender, EventArgs e)
        {
            Form teatro = new frmOnas();
            teatro.ShowDialog();
        }

        private void btnTobas_Click(object sender, EventArgs e)
        {
            Form teatro = new frmTobas();
            teatro.ShowDialog();
        }
    }
}