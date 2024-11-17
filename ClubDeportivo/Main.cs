using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClubDeportivo
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btnNewMember_Click(object sender, EventArgs e)
        {
            Form newMemberForm = new NewMemberForm();
            newMemberForm.Show();
        }

        private void MemberList_Click(object sender, EventArgs e)
        {
            Form memberList = new MemberList();
            memberList.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult mensaje = MessageBox.Show("¿Desea cerrar el programa?", "ALERTA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (mensaje == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
           
        }

        private void btnActivities_Click(object sender, EventArgs e)
        {
            Form actividadesForm = new Actividades();
            actividadesForm.Show();
        }
    }
}
